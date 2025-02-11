namespace Sitema2
{
    partial class Gerenciamento_Clientes
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.PesquisarClientes = new System.Windows.Forms.Button();
            this.RemoverClientes = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(64, 110);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(545, 311);
            this.dgvClientes.TabIndex = 0;
            // 
            // PesquisarClientes
            // 
            this.PesquisarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisarClientes.Location = new System.Drawing.Point(739, 110);
            this.PesquisarClientes.Name = "PesquisarClientes";
            this.PesquisarClientes.Size = new System.Drawing.Size(183, 63);
            this.PesquisarClientes.TabIndex = 1;
            this.PesquisarClientes.Text = "Pesquisar Clientes";
            this.PesquisarClientes.UseVisualStyleBackColor = true;
            // 
            // RemoverClientes
            // 
            this.RemoverClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverClientes.Location = new System.Drawing.Point(739, 220);
            this.RemoverClientes.Name = "RemoverClientes";
            this.RemoverClientes.Size = new System.Drawing.Size(183, 63);
            this.RemoverClientes.TabIndex = 2;
            this.RemoverClientes.Text = "Remover Clientes";
            this.RemoverClientes.UseVisualStyleBackColor = true;
            this.RemoverClientes.Click += new System.EventHandler(this.buttonRemoverClientes_Click);
            // 
            // Fechar
            // 
            this.Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechar.Location = new System.Drawing.Point(739, 340);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(183, 63);
            this.Fechar.TabIndex = 3;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gerenciamento de Clientes";
            // 
            // Gerenciamento_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.RemoverClientes);
            this.Controls.Add(this.PesquisarClientes);
            this.Controls.Add(this.dgvClientes);
            this.Name = "Gerenciamento_Clientes";
            this.Text = "Gerenciamento_Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button PesquisarClientes;
        private System.Windows.Forms.Button RemoverClientes;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Label label1;
    }
}