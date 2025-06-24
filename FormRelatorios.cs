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
    public partial class FormRelatorios : Form
    {
        public FormRelatorios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Conexao.StringConexao))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(@"
            SELECT p.Nome, p.Descricao, p.Quantidade, f.Nome AS Fornecedor
            FROM Produtos p
            JOIN Fornecedores f ON p.FornecedorId = f.Id", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                gridEstoque.DataSource = dt;
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime inicio = dtInicio.Value.Date;
            DateTime fim = dtFim.Value.Date.AddDays(1).AddSeconds(-1); // até o fim do dia

            using (SqlConnection conn = new SqlConnection(Conexao.StringConexao))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(@"
            SELECT p.Nome AS Produto, m.TipoMovimentacao, m.Quantidade, m.DataMovimentacao
            FROM Movimentacoes m
            JOIN Produtos p ON m.ProdutoId = p.Id
            WHERE m.DataMovimentacao BETWEEN @inicio AND @fim
            ORDER BY m.DataMovimentacao DESC", conn);

                da.SelectCommand.Parameters.AddWithValue("@inicio", inicio);
                da.SelectCommand.Parameters.AddWithValue("@fim", fim);

                DataTable dt = new DataTable();
                da.Fill(dt);
                gridMovimentacoes.DataSource = dt;
            }
        }
    }
}
