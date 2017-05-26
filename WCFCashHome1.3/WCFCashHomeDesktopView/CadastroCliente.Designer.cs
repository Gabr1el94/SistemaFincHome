namespace WCFCashHomeDesktopView
{
    partial class CadastroCliente
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextSenha = new System.Windows.Forms.TextBox();
            this.TextEmail = new System.Windows.Forms.TextBox();
            this.TextNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.mTxtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.mTxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(191, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 27);
            this.button3.TabIndex = 25;
            this.button3.Text = "Adicionar Conta";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 27);
            this.button2.TabIndex = 24;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Data de Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nome";
            // 
            // TextSenha
            // 
            this.TextSenha.Location = new System.Drawing.Point(12, 121);
            this.TextSenha.Name = "TextSenha";
            this.TextSenha.Size = new System.Drawing.Size(136, 20);
            this.TextSenha.TabIndex = 18;
            // 
            // TextEmail
            // 
            this.TextEmail.Location = new System.Drawing.Point(12, 77);
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.Size = new System.Drawing.Size(136, 20);
            this.TextEmail.TabIndex = 15;
            this.TextEmail.TextChanged += new System.EventHandler(this.TextEmail_TextChanged);
            // 
            // TextNome
            // 
            this.TextNome.Location = new System.Drawing.Point(12, 25);
            this.TextNome.Name = "TextNome";
            this.TextNome.Size = new System.Drawing.Size(136, 20);
            this.TextNome.TabIndex = 14;
            this.TextNome.TextChanged += new System.EventHandler(this.textBoxnome_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(208, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // mTxtNascimento
            // 
            this.mTxtNascimento.Location = new System.Drawing.Point(13, 168);
            this.mTxtNascimento.Mask = "00/00/0000";
            this.mTxtNascimento.Name = "mTxtNascimento";
            this.mTxtNascimento.Size = new System.Drawing.Size(135, 20);
            this.mTxtNascimento.TabIndex = 27;
            this.mTxtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // mTxtCpf
            // 
            this.mTxtCpf.Location = new System.Drawing.Point(12, 207);
            this.mTxtCpf.Mask = "000,000,000-00";
            this.mTxtCpf.Name = "mTxtCpf";
            this.mTxtCpf.Size = new System.Drawing.Size(135, 20);
            this.mTxtCpf.TabIndex = 28;
            this.mTxtCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 272);
            this.Controls.Add(this.mTxtCpf);
            this.Controls.Add(this.mTxtNascimento);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextSenha);
            this.Controls.Add(this.TextEmail);
            this.Controls.Add(this.TextNome);
            this.Controls.Add(this.button1);
            this.Name = "CadastroCliente";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextSenha;
        private System.Windows.Forms.TextBox TextEmail;
        private System.Windows.Forms.TextBox TextNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MaskedTextBox mTxtNascimento;
        private System.Windows.Forms.MaskedTextBox mTxtCpf;
    }
}

