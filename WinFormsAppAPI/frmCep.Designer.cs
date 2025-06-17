namespace Apresentacao
{
    partial class frmCep
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
            lblCep = new Label();
            mtbCep = new MaskedTextBox();
            btnBuscar = new Button();
            lbEstado = new Label();
            textBoxEstado = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(31, 19);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 0;
            lblCep.Text = "Cep";
            lblCep.Click += lblCep_Click;
            // 
            // mtbCep
            // 
            mtbCep.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtbCep.Location = new Point(85, 15);
            mtbCep.Mask = "00,000-00";
            mtbCep.Name = "mtbCep";
            mtbCep.Size = new Size(56, 23);
            mtbCep.TabIndex = 1;
            mtbCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(156, 15);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lbEstado
            // 
            lbEstado.AutoSize = true;
            lbEstado.Location = new Point(31, 57);
            lbEstado.Name = "lbEstado";
            lbEstado.Size = new Size(42, 15);
            lbEstado.TabIndex = 3;
            lbEstado.Text = "Estado";
            // 
            // textBoxEstado
            // 
            textBoxEstado.Location = new Point(79, 49);
            textBoxEstado.Name = "textBoxEstado";
            textBoxEstado.Size = new Size(39, 23);
            textBoxEstado.TabIndex = 4;
            textBoxEstado.TextChanged += textBoxEstado_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(575, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 98);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 5;
            label1.Text = "Cidade";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(575, 23);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 185);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 7;
            label2.Text = "Rua";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(79, 133);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(575, 23);
            textBox3.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 141);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 9;
            label3.Text = "Bairro";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(79, 219);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(575, 23);
            textBox4.TabIndex = 12;
            textBox4.TextChanged += this.textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 227);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 11;
            label4.Text = "Serviço";
            label4.Click += this.label4_Click;
            // 
            // frmCep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(textBoxEstado);
            Controls.Add(lbEstado);
            Controls.Add(btnBuscar);
            Controls.Add(mtbCep);
            Controls.Add(lblCep);
            Name = "frmCep";
            Text = "frmCep";
            Load += frmCep_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCep;
        private MaskedTextBox mtbCep;
        private Button btnBuscar;
        private Label lbEstado;
        private TextBox textBoxEstado;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
    }
}