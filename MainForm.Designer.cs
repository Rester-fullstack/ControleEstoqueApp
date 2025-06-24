namespace ControleEstoqueApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnMovimentacoes = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Location = new System.Drawing.Point(68, 148);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(185, 23);
            this.btnFornecedores.TabIndex = 1;
            this.btnFornecedores.Text = "Gerenciar Fornecedores";
            this.btnFornecedores.UseVisualStyleBackColor = true;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnMovimentacoes
            // 
            this.btnMovimentacoes.Location = new System.Drawing.Point(68, 246);
            this.btnMovimentacoes.Name = "btnMovimentacoes";
            this.btnMovimentacoes.Size = new System.Drawing.Size(185, 23);
            this.btnMovimentacoes.TabIndex = 2;
            this.btnMovimentacoes.Text = "Movimentações de Estoque";
            this.btnMovimentacoes.UseVisualStyleBackColor = true;
            this.btnMovimentacoes.Click += new System.EventHandler(this.btnMovimentacoes_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Location = new System.Drawing.Point(68, 344);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(75, 23);
            this.btnRelatorios.TabIndex = 3;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(68, 62);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(185, 23);
            this.btnProdutos.TabIndex = 4;
            this.btnProdutos.Text = "Gerenciar Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnMovimentacoes);
            this.Controls.Add(this.btnFornecedores);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnMovimentacoes;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnProdutos;
    }
}