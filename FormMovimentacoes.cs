using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControleEstoqueApp
{
    public partial class FormMovimentacoes : Form
    {
        public FormMovimentacoes()
        {
            InitializeComponent();
        }

        private void FormMovimentacoes_Load(object sender, EventArgs e)
        {
            // Carregar produtos
            using (SqlConnection conn = new SqlConnection(Conexao.StringConexao))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Nome FROM Produtos", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbProduto.DataSource = dt;
                cmbProduto.DisplayMember = "Nome";
                cmbProduto.ValueMember = "Id";
            }

            // Preencher tipos de movimentação
            cmbTipo.Items.Add("Entrada");
            cmbTipo.Items.Add("Saida");

            Listar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int produtoId = (int)cmbProduto.SelectedValue;
            string tipo = cmbTipo.SelectedItem.ToString();
            int quantidade = int.Parse(txtQuantidade.Text);

            using (SqlConnection conn = new SqlConnection(Conexao.StringConexao))
            {
                conn.Open();

                // Inserir movimentação
                SqlCommand cmd = new SqlCommand("INSERT INTO Movimentacoes (ProdutoId, TipoMovimentacao, Quantidade) VALUES (@pid, @tipo, @qtd)", conn);
                cmd.Parameters.AddWithValue("@pid", produtoId);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@qtd", quantidade);
                cmd.ExecuteNonQuery();

                // Atualizar quantidade no estoque
                SqlCommand cmdUpdate;
                if (tipo == "Entrada")
                {
                    cmdUpdate = new SqlCommand("UPDATE Produtos SET Quantidade = Quantidade + @qtd WHERE Id = @id", conn);
                }
                else
                {
                    cmdUpdate = new SqlCommand("UPDATE Produtos SET Quantidade = Quantidade - @qtd WHERE Id = @id", conn);
                }

                cmdUpdate.Parameters.AddWithValue("@qtd", quantidade);
                cmdUpdate.Parameters.AddWithValue("@id", produtoId);
                cmdUpdate.ExecuteNonQuery();

                MessageBox.Show("Movimentação registrada!");
                Listar();
            }
        }

        private void Listar()
        {
            using (SqlConnection conn = new SqlConnection(Conexao.StringConexao))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(@"
            SELECT m.Id, p.Nome AS Produto, m.TipoMovimentacao, m.Quantidade, m.DataMovimentacao 
            FROM Movimentacoes m 
            JOIN Produtos p ON m.ProdutoId = p.Id
            ORDER BY m.DataMovimentacao DESC", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

    }
}
