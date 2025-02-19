namespace DamajuCad
{
    partial class Gerenciamento_Produtos
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
            this.label1 = new System.Windows.Forms.Label();
            this.Gerenciar_Produtos = new System.Windows.Forms.DataGridView();
            this.Voltar = new System.Windows.Forms.Button();
            this.RemoverProdutos = new System.Windows.Forms.Button();
            this.PesquisarProdutos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Gerenciar_Produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gerenciamento Produtos";
            // 
            // Gerenciar_Produtos
            // 
            this.Gerenciar_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gerenciar_Produtos.Location = new System.Drawing.Point(101, 182);
            this.Gerenciar_Produtos.Name = "Gerenciar_Produtos";
            this.Gerenciar_Produtos.Size = new System.Drawing.Size(568, 341);
            this.Gerenciar_Produtos.TabIndex = 8;
            // 
            // Voltar
            // 
            this.Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.Location = new System.Drawing.Point(724, 462);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(197, 61);
            this.Voltar.TabIndex = 7;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            // 
            // RemoverProdutos
            // 
            this.RemoverProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverProdutos.Location = new System.Drawing.Point(724, 317);
            this.RemoverProdutos.Name = "RemoverProdutos";
            this.RemoverProdutos.Size = new System.Drawing.Size(197, 61);
            this.RemoverProdutos.TabIndex = 6;
            this.RemoverProdutos.Text = "Remover Produtos";
            this.RemoverProdutos.UseVisualStyleBackColor = true;
            // 
            // PesquisarProdutos
            // 
            this.PesquisarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisarProdutos.Location = new System.Drawing.Point(724, 182);
            this.PesquisarProdutos.Name = "PesquisarProdutos";
            this.PesquisarProdutos.Size = new System.Drawing.Size(197, 61);
            this.PesquisarProdutos.TabIndex = 5;
            this.PesquisarProdutos.Text = "Pesquisar Produtos";
            this.PesquisarProdutos.UseVisualStyleBackColor = true;
            // 
            // Gerenciamento_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1023, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gerenciar_Produtos);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.RemoverProdutos);
            this.Controls.Add(this.PesquisarProdutos);
            this.Name = "Gerenciamento_Produtos";
            this.Text = "Gerenciamento_Lanches";
            ((System.ComponentModel.ISupportInitialize)(this.Gerenciar_Produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Gerenciar_Produtos;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button RemoverProdutos;
        private System.Windows.Forms.Button PesquisarProdutos;
    }
}