using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoqueApp
{
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            // Carregar fornecedores no combo
            using (SqlConnection conn = new SqlConnection(Conexao.StringConexao))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Nome FROM Fornecedores", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbFornecedor.DataSource = dt;
                cmbFornecedor.DisplayMember = "Nome";
                cmbFornecedor.ValueMember = "Id";
            }

            Listar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Conexao.StringConexao))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Produtos (Nome, Descricao, Quantidade, FornecedorId) VALUES (@nome, @descricao, @quantidade, @fornecedor)", conn);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                cmd.Parameters.AddWithValue("@quantidade", int.Parse(txtQuantidade.Text));
                cmd.Parameters.AddWithValue("@fornecedor", cmbFornecedor.SelectedValue);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto adicionado!");
                Listar();
            }
        }

        private void Listar()
        {
            using (SqlConnection conn = new SqlConnection(Conexao.StringConexao))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT p.Id, p.Nome, p.Descricao, p.Quantidade, f.Nome AS Fornecedor FROM Produtos p JOIN Fornecedores f ON p.FornecedorId = f.Id",
                    conn
                );
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                using (SqlConnection conn = new SqlConnection(Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Produtos SET Nome=@nome, Descricao=@descricao, Quantidade=@quantidade, FornecedorId=@fornecedor WHERE Id=@id", conn);
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("@quantidade", int.Parse(txtQuantidade.Text));
                    cmd.Parameters.AddWithValue("@fornecedor", cmbFornecedor.SelectedValue);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto atualizado!");
                    Listar();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                using (SqlConnection conn = new SqlConnection(Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Produtos WHERE Id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto excluído!");
                    Listar();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtNome.Text = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
                txtDescricao.Text = dataGridView1.CurrentRow.Cells["Descricao"].Value.ToString();
                txtQuantidade.Text = dataGridView1.CurrentRow.Cells["Quantidade"].Value.ToString();
                cmbFornecedor.Text = dataGridView1.CurrentRow.Cells["Fornecedor"].Value.ToString();
            }
        }
    }
}
