using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControleEstoqueApp
{
    public partial class FormFornecedores : Form
    {
        public FormFornecedores()
        {
            InitializeComponent();
        }

        private void FormFornecedores_Load(object sender, EventArgs e)
        {

        }

        private void txtCNPJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                using (SqlConnection conn = new SqlConnection(Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Fornecedores WHERE Id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fornecedor excluído!");
                    Listar();
                }
            }

        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Conexao.StringConexao))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Fornecedores (Nome, CNPJ, Telefone) VALUES (@nome, @cnpj, @telefone)", conn);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cnpj", txtCNPJ.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor adicionado!");
                Listar();
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                using (SqlConnection conn = new SqlConnection(Conexao.StringConexao))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Fornecedores SET Nome=@nome, CNPJ=@cnpj, Telefone=@telefone WHERE Id=@id", conn);
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@cnpj", txtCNPJ.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fornecedor atualizado!");
                    Listar();
                }
            }
        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            using (SqlConnection conn = new SqlConnection(Conexao.StringConexao))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Fornecedores", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtNome.Text = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
                txtCNPJ.Text = dataGridView1.CurrentRow.Cells["CNPJ"].Value.ToString();
                txtTelefone.Text = dataGridView1.CurrentRow.Cells["Telefone"].Value.ToString();
            }
        }
    }
}
