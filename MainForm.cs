using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoqueApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            FormRelatorios form = new FormRelatorios();
            form.ShowDialog();
        }

        private void btnMovimentacoes_Click(object sender, EventArgs e)
        {
            FormMovimentacoes form = new FormMovimentacoes();
            form.ShowDialog();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            FormFornecedores form = new FormFornecedores();
            form.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos form = new FormProdutos();
            form.ShowDialog();
        }
    }
}
