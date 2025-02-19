namespace DamajuCad
{
    partial class CadClientes
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
            this.Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Numero = new System.Windows.Forms.MaskedTextBox();
            this.Cpf = new System.Windows.Forms.MaskedTextBox();
            this.Nome = new System.Windows.Forms.MaskedTextBox();
            this.Email = new System.Windows.Forms.MaskedTextBox();
            this.Senha = new System.Windows.Forms.MaskedTextBox();
            this.Cep = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.Cadastrar_Clientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Telefone
            // 
            this.Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.Location = new System.Drawing.Point(534, 280);
            this.Telefone.Mask = "(00) 00000-0000";
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(210, 22);
            this.Telefone.TabIndex = 12;
            // 
            // Numero
            // 
            this.Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero.Location = new System.Drawing.Point(534, 222);
            this.Numero.Mask = "00000";
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(210, 22);
            this.Numero.TabIndex = 13;
            // 
            // Cpf
            // 
            this.Cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cpf.Location = new System.Drawing.Point(534, 164);
            this.Cpf.Mask = "000.000.000.-00";
            this.Cpf.Name = "Cpf";
            this.Cpf.Size = new System.Drawing.Size(210, 22);
            this.Cpf.TabIndex = 14;
            // 
            // Nome
            // 
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(168, 135);
            this.Nome.Mask = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
    "aaaaaaaaaa";
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(210, 22);
            this.Nome.TabIndex = 18;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(168, 193);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(210, 22);
            this.Email.TabIndex = 17;
            // 
            // Senha
            // 
            this.Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.Location = new System.Drawing.Point(168, 251);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(210, 22);
            this.Senha.TabIndex = 16;
            // 
            // Cep
            // 
            this.Cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cep.Location = new System.Drawing.Point(168, 303);
            this.Cep.Mask = "00-000-000";
            this.Cep.Name = "Cep";
            this.Cep.Size = new System.Drawing.Size(210, 22);
            this.Cep.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cadastrar Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(409, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Numero Casa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "CPF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Cep";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(98, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Senha";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(104, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Email";
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVoltar.BackColor = System.Drawing.Color.White;
            this.buttonVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.Location = new System.Drawing.Point(30, 31);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(115, 26);
            this.buttonVoltar.TabIndex = 28;
            this.buttonVoltar.Text = "Voltar pra Menu";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            // 
            // Cadastrar_Clientes
            // 
            this.Cadastrar_Clientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cadastrar_Clientes.BackColor = System.Drawing.Color.White;
            this.Cadastrar_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar_Clientes.Location = new System.Drawing.Point(343, 368);
            this.Cadastrar_Clientes.Name = "Cadastrar_Clientes";
            this.Cadastrar_Clientes.Size = new System.Drawing.Size(171, 42);
            this.Cadastrar_Clientes.TabIndex = 29;
            this.Cadastrar_Clientes.Text = "Cadastrar";
            this.Cadastrar_Clientes.UseVisualStyleBackColor = false;
            this.Cadastrar_Clientes.Click += new System.EventHandler(this.Cadastrar_Clientes_Click_1);
            // 
            // CadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cadastrar_Clientes);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Cep);
            this.Controls.Add(this.Cpf);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.Telefone);
            this.Name = "CadClientes";
            this.Text = "CadClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox Telefone;
        private System.Windows.Forms.MaskedTextBox Numero;
        private System.Windows.Forms.MaskedTextBox Cpf;
        private System.Windows.Forms.MaskedTextBox Nome;
        private System.Windows.Forms.MaskedTextBox Email;
        private System.Windows.Forms.MaskedTextBox Senha;
        private System.Windows.Forms.MaskedTextBox Cep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button Cadastrar_Clientes;
    }
}