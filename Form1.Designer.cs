namespace Nosso_Banco
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_gerarSenhaPref = new System.Windows.Forms.Button();
            this.list_senhas = new System.Windows.Forms.ListBox();
            this.btn_gerarSenhaNorm = new System.Windows.Forms.Button();
            this.btn_chamarSenha = new System.Windows.Forms.Button();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_operações = new System.Windows.Forms.TextBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_virgula = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_sacar = new System.Windows.Forms.Button();
            this.btn_depositar = new System.Windows.Forms.Button();
            this.btn_saldo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.list_histórico = new System.Windows.Forms.ListBox();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_gerarSenhaPref);
            this.groupBox1.Controls.Add(this.list_senhas);
            this.groupBox1.Controls.Add(this.btn_gerarSenhaNorm);
            this.groupBox1.Controls.Add(this.btn_chamarSenha);
            this.groupBox1.Controls.Add(this.txt_Senha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_gerarSenhaPref
            // 
            this.btn_gerarSenhaPref.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerarSenhaPref.Location = new System.Drawing.Point(7, 248);
            this.btn_gerarSenhaPref.Name = "btn_gerarSenhaPref";
            this.btn_gerarSenhaPref.Size = new System.Drawing.Size(187, 45);
            this.btn_gerarSenhaPref.TabIndex = 2;
            this.btn_gerarSenhaPref.Text = "Preferêncial";
            this.btn_gerarSenhaPref.UseVisualStyleBackColor = true;
            this.btn_gerarSenhaPref.Click += new System.EventHandler(this.btn_gerarSenhaPref_Click);
            // 
            // list_senhas
            // 
            this.list_senhas.BackColor = System.Drawing.SystemColors.Control;
            this.list_senhas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_senhas.Enabled = false;
            this.list_senhas.FormattingEnabled = true;
            this.list_senhas.Location = new System.Drawing.Point(200, 61);
            this.list_senhas.Name = "list_senhas";
            this.list_senhas.Size = new System.Drawing.Size(35, 234);
            this.list_senhas.TabIndex = 4;
            // 
            // btn_gerarSenhaNorm
            // 
            this.btn_gerarSenhaNorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerarSenhaNorm.Location = new System.Drawing.Point(6, 200);
            this.btn_gerarSenhaNorm.Name = "btn_gerarSenhaNorm";
            this.btn_gerarSenhaNorm.Size = new System.Drawing.Size(187, 45);
            this.btn_gerarSenhaNorm.TabIndex = 1;
            this.btn_gerarSenhaNorm.Text = "Normal";
            this.btn_gerarSenhaNorm.UseVisualStyleBackColor = true;
            this.btn_gerarSenhaNorm.Click += new System.EventHandler(this.btn_gerarSenha_Click);
            // 
            // btn_chamarSenha
            // 
            this.btn_chamarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chamarSenha.Location = new System.Drawing.Point(7, 131);
            this.btn_chamarSenha.Name = "btn_chamarSenha";
            this.btn_chamarSenha.Size = new System.Drawing.Size(187, 45);
            this.btn_chamarSenha.TabIndex = 3;
            this.btn_chamarSenha.Text = "Chamar Senha";
            this.btn_chamarSenha.UseVisualStyleBackColor = true;
            this.btn_chamarSenha.Click += new System.EventHandler(this.btn_chamarSenha_Click);
            // 
            // txt_Senha
            // 
            this.txt_Senha.Enabled = false;
            this.txt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(7, 45);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(187, 80);
            this.txt_Senha.TabIndex = 1;
            this.txt_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SENHAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "GERAR SENHAS";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(4, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 108);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTA";
            // 
            // txt_operações
            // 
            this.txt_operações.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_operações.Location = new System.Drawing.Point(261, 57);
            this.txt_operações.Name = "txt_operações";
            this.txt_operações.Size = new System.Drawing.Size(361, 44);
            this.txt_operações.TabIndex = 4;
            this.txt_operações.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(261, 107);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(61, 47);
            this.btn_1.TabIndex = 4;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(328, 107);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(61, 47);
            this.btn_2.TabIndex = 5;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(395, 107);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(61, 47);
            this.btn_3.TabIndex = 6;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(261, 160);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(61, 47);
            this.btn_4.TabIndex = 7;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(328, 160);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(61, 47);
            this.btn_5.TabIndex = 8;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(395, 160);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(61, 47);
            this.btn_6.TabIndex = 9;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(261, 213);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(61, 47);
            this.btn_7.TabIndex = 10;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(328, 213);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(61, 47);
            this.btn_8.TabIndex = 11;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(395, 213);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(61, 47);
            this.btn_9.TabIndex = 12;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_virgula
            // 
            this.btn_virgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_virgula.Location = new System.Drawing.Point(261, 266);
            this.btn_virgula.Name = "btn_virgula";
            this.btn_virgula.Size = new System.Drawing.Size(61, 47);
            this.btn_virgula.TabIndex = 13;
            this.btn_virgula.Text = ".";
            this.btn_virgula.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_virgula.UseVisualStyleBackColor = true;
            this.btn_virgula.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(328, 266);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(61, 47);
            this.btn_0.TabIndex = 14;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_sacar
            // 
            this.btn_sacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sacar.Location = new System.Drawing.Point(462, 107);
            this.btn_sacar.Name = "btn_sacar";
            this.btn_sacar.Size = new System.Drawing.Size(160, 47);
            this.btn_sacar.TabIndex = 16;
            this.btn_sacar.Text = "SACAR";
            this.btn_sacar.UseVisualStyleBackColor = true;
            this.btn_sacar.Click += new System.EventHandler(this.btn_sacar_Click);
            // 
            // btn_depositar
            // 
            this.btn_depositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_depositar.Location = new System.Drawing.Point(462, 160);
            this.btn_depositar.Name = "btn_depositar";
            this.btn_depositar.Size = new System.Drawing.Size(160, 47);
            this.btn_depositar.TabIndex = 17;
            this.btn_depositar.Text = "DEPOSITAR";
            this.btn_depositar.UseVisualStyleBackColor = true;
            this.btn_depositar.Click += new System.EventHandler(this.btn_depositar_Click);
            // 
            // btn_saldo
            // 
            this.btn_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saldo.Location = new System.Drawing.Point(462, 213);
            this.btn_saldo.Name = "btn_saldo";
            this.btn_saldo.Size = new System.Drawing.Size(160, 47);
            this.btn_saldo.TabIndex = 18;
            this.btn_saldo.Text = "SALDO";
            this.btn_saldo.UseVisualStyleBackColor = true;
            this.btn_saldo.Click += new System.EventHandler(this.btn_saldo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(651, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "HISTÓRICO";
            // 
            // list_histórico
            // 
            this.list_histórico.Enabled = false;
            this.list_histórico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_histórico.FormattingEnabled = true;
            this.list_histórico.ItemHeight = 18;
            this.list_histórico.Location = new System.Drawing.Point(629, 57);
            this.list_histórico.Name = "list_histórico";
            this.list_histórico.Size = new System.Drawing.Size(168, 256);
            this.list_histórico.TabIndex = 20;
            // 
            // txt_saldo
            // 
            this.txt_saldo.Enabled = false;
            this.txt_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_saldo.Location = new System.Drawing.Point(462, 266);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(161, 44);
            this.txt_saldo.TabIndex = 21;
            this.txt_saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(395, 266);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(61, 47);
            this.btn_clear.TabIndex = 15;
            this.btn_clear.Text = "←";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(809, 321);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_saldo);
            this.Controls.Add(this.list_histórico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_saldo);
            this.Controls.Add(this.btn_depositar);
            this.Controls.Add(this.btn_sacar);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_virgula);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.txt_operações);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "NOSSO BANCO";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_gerarSenhaNorm;
        private System.Windows.Forms.Button btn_chamarSenha;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_operações;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_virgula;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_sacar;
        private System.Windows.Forms.Button btn_depositar;
        private System.Windows.Forms.Button btn_saldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox list_histórico;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ListBox list_senhas;
        private System.Windows.Forms.Button btn_gerarSenhaPref;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

