namespace WinFormsAppAula1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtTexto = new TextBox();
            TxtResultado = new TextBox();
            LbResultado = new Label();
            lbTexto = new Label();
            rbMasculino = new CheckBox();
            rbFeminino = new CheckBox();
            textBox1 = new TextBox();
            txtSenha = new Label();
            chAtivo = new CheckBox();
            cbTimes = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(560, 323);
            button1.Name = "button1";
            button1.Size = new Size(69, 38);
            button1.TabIndex = 0;
            button1.Text = "menssage";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.AllowDrop = true;
            button2.Location = new Point(144, 299);
            button2.Name = "button2";
            button2.Size = new Size(77, 23);
            button2.TabIndex = 1;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(255, 299);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtTexto
            // 
            txtTexto.BackColor = SystemColors.Window;
            txtTexto.Location = new Point(144, 172);
            txtTexto.Multiline = true;
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(186, 107);
            txtTexto.TabIndex = 3;
            // 
            // TxtResultado
            // 
            TxtResultado.Location = new Point(144, 119);
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(186, 23);
            TxtResultado.TabIndex = 4;
            // 
            // LbResultado
            // 
            LbResultado.AutoSize = true;
            LbResultado.Location = new Point(144, 101);
            LbResultado.Name = "LbResultado";
            LbResultado.Size = new Size(59, 15);
            LbResultado.TabIndex = 5;
            LbResultado.Text = "Resultado";
            // 
            // lbTexto
            // 
            lbTexto.AutoSize = true;
            lbTexto.Location = new Point(144, 154);
            lbTexto.Name = "lbTexto";
            lbTexto.Size = new Size(35, 15);
            lbTexto.TabIndex = 7;
            lbTexto.Text = "Texto";
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(352, 188);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(81, 19);
            rbMasculino.TabIndex = 8;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            rbFeminino.AutoSize = true;
            rbFeminino.Location = new Point(352, 224);
            rbFeminino.Name = "rbFeminino";
            rbFeminino.Size = new Size(76, 19);
            rbFeminino.TabIndex = 9;
            rbFeminino.Text = "Feminino";
            rbFeminino.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(362, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            // 
            // txtSenha
            // 
            txtSenha.AutoSize = true;
            txtSenha.Location = new Point(362, 101);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(39, 15);
            txtSenha.TabIndex = 11;
            txtSenha.Text = "Senha";
            // 
            // chAtivo
            // 
            chAtivo.AutoSize = true;
            chAtivo.Location = new Point(492, 209);
            chAtivo.Name = "chAtivo";
            chAtivo.Size = new Size(54, 19);
            chAtivo.TabIndex = 12;
            chAtivo.Text = "Ativo";
            chAtivo.UseVisualStyleBackColor = true;
            // 
            // cbTimes
            // 
            cbTimes.FormattingEnabled = true;
            cbTimes.Items.AddRange(new object[] { "Palmeiras", "Santos", "São Paulo", "Corinthans" });
            cbTimes.Location = new Point(508, 119);
            cbTimes.Name = "cbTimes";
            cbTimes.Size = new Size(121, 23);
            cbTimes.TabIndex = 13;
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(650, 406);
            Controls.Add(cbTimes);
            Controls.Add(chAtivo);
            Controls.Add(txtSenha);
            Controls.Add(textBox1);
            Controls.Add(rbFeminino);
            Controls.Add(rbMasculino);
            Controls.Add(lbTexto);
            Controls.Add(LbResultado);
            Controls.Add(TxtResultado);
            Controls.Add(txtTexto);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtTexto;
        private TextBox TxtResultado;
        private Label LbResultado;
        private Label lbTexto;
        private CheckBox rbMasculino;
        private CheckBox rbFeminino;
        private TextBox textBox1;
        private Label txtSenha;
        private CheckBox chAtivo;
        private ComboBox cbTimes;
    }
}
