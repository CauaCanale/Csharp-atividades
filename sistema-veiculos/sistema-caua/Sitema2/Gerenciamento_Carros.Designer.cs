namespace Sitema2
{
    partial class Gerenciamento_Carros
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
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.PesquisarCarros = new System.Windows.Forms.Button();
            this.buttonRemoverCarros = new System.Windows.Forms.Button();
            this.ButtonFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciamento de Carros";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvCarros
            // 
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Location = new System.Drawing.Point(66, 143);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.Size = new System.Drawing.Size(496, 326);
            this.dgvCarros.TabIndex = 1;
            // 
            // PesquisarCarros
            // 
            this.PesquisarCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisarCarros.Location = new System.Drawing.Point(652, 163);
            this.PesquisarCarros.Name = "PesquisarCarros";
            this.PesquisarCarros.Size = new System.Drawing.Size(190, 71);
            this.PesquisarCarros.TabIndex = 2;
            this.PesquisarCarros.Text = "Pesquisar Carros";
            this.PesquisarCarros.UseVisualStyleBackColor = true;
            this.PesquisarCarros.Click += new System.EventHandler(this.PesquisarCarros_Click);
            // 
            // buttonRemoverCarros
            // 
            this.buttonRemoverCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoverCarros.Location = new System.Drawing.Point(652, 268);
            this.buttonRemoverCarros.Name = "buttonRemoverCarros";
            this.buttonRemoverCarros.Size = new System.Drawing.Size(190, 71);
            this.buttonRemoverCarros.TabIndex = 3;
            this.buttonRemoverCarros.Text = "Remover Carros";
            this.buttonRemoverCarros.UseVisualStyleBackColor = true;
            this.buttonRemoverCarros.Click += new System.EventHandler(this.buttonRemoverCarros_Click_1);
            // 
            // ButtonFechar
            // 
            this.ButtonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFechar.Location = new System.Drawing.Point(652, 371);
            this.ButtonFechar.Name = "ButtonFechar";
            this.ButtonFechar.Size = new System.Drawing.Size(190, 71);
            this.ButtonFechar.TabIndex = 4;
            this.ButtonFechar.Text = "Fechar";
            this.ButtonFechar.UseVisualStyleBackColor = true;
            // 
            // Gerenciamento_Carros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 555);
            this.Controls.Add(this.ButtonFechar);
            this.Controls.Add(this.buttonRemoverCarros);
            this.Controls.Add(this.PesquisarCarros);
            this.Controls.Add(this.dgvCarros);
            this.Controls.Add(this.label1);
            this.Name = "Gerenciamento_Carros";
            this.Text = "Gerenciamento_Carros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.Button PesquisarCarros;
        private System.Windows.Forms.Button buttonRemoverCarros;
        private System.Windows.Forms.Button ButtonFechar;
    }
}