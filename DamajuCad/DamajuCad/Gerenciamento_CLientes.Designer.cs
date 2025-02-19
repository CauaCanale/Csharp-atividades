namespace DamajuCad
{
    partial class Gerenciamento_CLientes
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
            this.PesquisarClientes = new System.Windows.Forms.Button();
            this.RemoverClientes = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.Gerenciar_Clientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Gerenciar_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // PesquisarClientes
            // 
            this.PesquisarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisarClientes.Location = new System.Drawing.Point(716, 163);
            this.PesquisarClientes.Name = "PesquisarClientes";
            this.PesquisarClientes.Size = new System.Drawing.Size(197, 61);
            this.PesquisarClientes.TabIndex = 0;
            this.PesquisarClientes.Text = "Pesquisar Clientes";
            this.PesquisarClientes.UseVisualStyleBackColor = true;
            // 
            // RemoverClientes
            // 
            this.RemoverClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverClientes.Location = new System.Drawing.Point(716, 298);
            this.RemoverClientes.Name = "RemoverClientes";
            this.RemoverClientes.Size = new System.Drawing.Size(197, 61);
            this.RemoverClientes.TabIndex = 1;
            this.RemoverClientes.Text = "Remover Clientes";
            this.RemoverClientes.UseVisualStyleBackColor = true;
            this.RemoverClientes.Click += new System.EventHandler(this.buttonRemoverClientes_Click);
            // 
            // Voltar
            // 
            this.Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.Location = new System.Drawing.Point(716, 443);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(197, 61);
            this.Voltar.TabIndex = 2;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            // 
            // Gerenciar_Clientes
            // 
            this.Gerenciar_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gerenciar_Clientes.Location = new System.Drawing.Point(93, 163);
            this.Gerenciar_Clientes.Name = "Gerenciar_Clientes";
            this.Gerenciar_Clientes.Size = new System.Drawing.Size(568, 341);
            this.Gerenciar_Clientes.TabIndex = 3;
            this.Gerenciar_Clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gerenciar_Clientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gerenciamento Clientes";
            // 
            // Gerenciamento_CLientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1045, 604);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gerenciar_Clientes);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.RemoverClientes);
            this.Controls.Add(this.PesquisarClientes);
            this.Name = "Gerenciamento_CLientes";
            this.Text = "Gerenciamento_CLientes";
            ((System.ComponentModel.ISupportInitialize)(this.Gerenciar_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PesquisarClientes;
        private System.Windows.Forms.Button RemoverClientes;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.DataGridView Gerenciar_Clientes;
        private System.Windows.Forms.Label label1;
    }
}