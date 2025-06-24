using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControleEstoqueApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Conexao.StringConexao))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Login=@login AND Senha=@senha", conn);
                cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MainForm tela = new MainForm();
                    tela.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login inválido");
                }
            }
        }
    }
}
