namespace WinFormsAppAPI
{
    partial class Feriado
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
            pictureBox1 = new PictureBox();
            Ano = new Label();
            mtbAno = new MaskedTextBox();
            btnBuscar = new Button();
            dgvFeriados = new DataGridView();
            collData = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            btnColuna = new Button();
            btnLinha = new Button();
            btnRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFeriados).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Apresentacao.Properties.Resources.calendar;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 63);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Ano
            // 
            Ano.AutoSize = true;
            Ano.Location = new Point(96, 35);
            Ano.Name = "Ano";
            Ano.Size = new Size(29, 15);
            Ano.TabIndex = 0;
            Ano.Text = "Ano";
            // 
            // mtbAno
            // 
            mtbAno.Location = new Point(96, 53);
            mtbAno.Mask = "0000";
            mtbAno.Name = "mtbAno";
            mtbAno.Size = new Size(51, 23);
            mtbAno.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Location = new Point(153, 52);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "&F5 Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvFeriados
            // 
            dgvFeriados.AllowUserToAddRows = false;
            dgvFeriados.AllowUserToDeleteRows = false;
            dgvFeriados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFeriados.Columns.AddRange(new DataGridViewColumn[] { collData, Column1 });
            dgvFeriados.Location = new Point(12, 112);
            dgvFeriados.Name = "dgvFeriados";
            dgvFeriados.ReadOnly = true;
            dgvFeriados.Size = new Size(730, 297);
            dgvFeriados.TabIndex = 3;
            // 
            // collData
            // 
            collData.DataPropertyName = "Name";
            collData.HeaderText = "Nome";
            collData.Name = "collData";
            collData.ReadOnly = true;
            collData.ToolTipText = "Nome dos feriados";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "date";
            Column1.HeaderText = "Data";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.ToolTipText = "Data do feriado";
            // 
            // btnColuna
            // 
            btnColuna.Location = new Point(12, 415);
            btnColuna.Name = "btnColuna";
            btnColuna.Size = new Size(75, 23);
            btnColuna.TabIndex = 4;
            btnColuna.Text = "Coluna";
            btnColuna.UseVisualStyleBackColor = true;
            btnColuna.Click += btnColuna_Click;
            // 
            // btnLinha
            // 
            btnLinha.Location = new Point(96, 415);
            btnLinha.Name = "btnLinha";
            btnLinha.Size = new Size(75, 23);
            btnLinha.TabIndex = 5;
            btnLinha.Text = "Linha";
            btnLinha.UseVisualStyleBackColor = true;
            btnLinha.Click += btnLinha_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(177, 415);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 6;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // Feriado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemover);
            Controls.Add(btnLinha);
            Controls.Add(btnColuna);
            Controls.Add(dgvFeriados);
            Controls.Add(btnBuscar);
            Controls.Add(mtbAno);
            Controls.Add(Ano);
            Controls.Add(pictureBox1);
            Name = "Feriado";
            Text = "Feriados";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFeriados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Ano;
        private MaskedTextBox mtbAno;
        private Button btnBuscar;
        private DataGridView dgvFeriados;
        private Button btnColuna;
        private DataGridViewTextBoxColumn collData;
        private DataGridViewTextBoxColumn Column1;
        private Button btnLinha;
        private Button btnRemover;
    }
}
