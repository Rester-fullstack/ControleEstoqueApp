namespace ControleEstoqueApp
{
    partial class FormRelatorios
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
            this.gridEstoque = new System.Windows.Forms.DataGridView();
            this.btnEstoqueAtual = new System.Windows.Forms.Button();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.gridMovimentacoes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovimentacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEstoque
            // 
            this.gridEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEstoque.Location = new System.Drawing.Point(58, 30);
            this.gridEstoque.Name = "gridEstoque";
            this.gridEstoque.RowHeadersWidth = 53;
            this.gridEstoque.RowTemplate.Height = 24;
            this.gridEstoque.Size = new System.Drawing.Size(394, 306);
            this.gridEstoque.TabIndex = 0;
            // 
            // btnEstoqueAtual
            // 
            this.btnEstoqueAtual.Location = new System.Drawing.Point(188, 360);
            this.btnEstoqueAtual.Name = "btnEstoqueAtual";
            this.btnEstoqueAtual.Size = new System.Drawing.Size(161, 64);
            this.btnEstoqueAtual.TabIndex = 1;
            this.btnEstoqueAtual.Text = "Exibir Estoque Atual";
            this.btnEstoqueAtual.UseVisualStyleBackColor = true;
            this.btnEstoqueAtual.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(475, 56);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 22);
            this.dtInicio.TabIndex = 2;
            // 
            // dtFim
            // 
            this.dtFim.Location = new System.Drawing.Point(475, 118);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(200, 22);
            this.dtFim.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(490, 183);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(171, 23);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtar Movimentações";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // gridMovimentacoes
            // 
            this.gridMovimentacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMovimentacoes.Location = new System.Drawing.Point(708, 42);
            this.gridMovimentacoes.Name = "gridMovimentacoes";
            this.gridMovimentacoes.RowHeadersWidth = 53;
            this.gridMovimentacoes.RowTemplate.Height = 24;
            this.gridMovimentacoes.Size = new System.Drawing.Size(382, 382);
            this.gridMovimentacoes.TabIndex = 5;
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 450);
            this.Controls.Add(this.gridMovimentacoes);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.btnEstoqueAtual);
            this.Controls.Add(this.gridEstoque);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            ((System.ComponentModel.ISupportInitialize)(this.gridEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovimentacoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEstoque;
        private System.Windows.Forms.Button btnEstoqueAtual;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView gridMovimentacoes;
    }
}