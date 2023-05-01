namespace CapaPresentaciòn.BtControles
{
    partial class UserPadres
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            labelnNameGrupo = new Label();
            dataGridViewGrupos = new DataGridView();
            panel1 = new Panel();
            NumMujeres = new Label();
            label1 = new Label();
            panel2 = new Panel();
            NumHombres = new Label();
            label3 = new Label();
            panel3 = new Panel();
            NumPani = new Label();
            label5 = new Label();
            panel4 = new Panel();
            NumImas = new Label();
            label7 = new Label();
            panel5 = new Panel();
            NumPrivados = new Label();
            label9 = new Label();
            comboBoxGrupos = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            anno = new Label();
            labelNameDocente = new Label();
            labelNameAsistente = new Label();
            buttonPdf = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrupos).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // labelnNameGrupo
            // 
            labelnNameGrupo.Anchor = AnchorStyles.Top;
            labelnNameGrupo.AutoSize = true;
            labelnNameGrupo.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelnNameGrupo.ForeColor = SystemColors.ActiveCaptionText;
            labelnNameGrupo.Location = new Point(664, 18);
            labelnNameGrupo.Name = "labelnNameGrupo";
            labelnNameGrupo.Size = new Size(171, 56);
            labelnNameGrupo.TabIndex = 4;
            labelnNameGrupo.Text = "Grupo";
            labelnNameGrupo.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridViewGrupos
            // 
            dataGridViewGrupos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewGrupos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGrupos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewGrupos.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewGrupos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewGrupos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGrupos.GridColor = Color.FromArgb(255, 128, 0);
            dataGridViewGrupos.Location = new Point(17, 140);
            dataGridViewGrupos.Name = "dataGridViewGrupos";
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewGrupos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewGrupos.RowTemplate.Height = 25;
            dataGridViewGrupos.Size = new Size(1459, 384);
            dataGridViewGrupos.TabIndex = 5;
            dataGridViewGrupos.CellContentClick += dataGridViewGrupos_CellContentClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(NumMujeres);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(429, 540);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 92);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // NumMujeres
            // 
            NumMujeres.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            NumMujeres.AutoSize = true;
            NumMujeres.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            NumMujeres.Location = new Point(61, 50);
            NumMujeres.Name = "NumMujeres";
            NumMujeres.Size = new Size(34, 25);
            NumMujeres.TabIndex = 1;
            NumMujeres.Text = "00";
            NumMujeres.Click += NumMujeres_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 13);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 0;
            label1.Text = "Mujeres";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(NumHombres);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(647, 540);
            panel2.Name = "panel2";
            panel2.Size = new Size(178, 92);
            panel2.TabIndex = 7;
            // 
            // NumHombres
            // 
            NumHombres.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            NumHombres.AutoSize = true;
            NumHombres.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            NumHombres.Location = new Point(67, 50);
            NumHombres.Name = "NumHombres";
            NumHombres.Size = new Size(34, 25);
            NumHombres.TabIndex = 1;
            NumHombres.Text = "00";
            NumHombres.Click += NumHombres_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 13);
            label3.Name = "label3";
            label3.Size = new Size(116, 28);
            label3.TabIndex = 0;
            label3.Text = "Hombres";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(NumPani);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(866, 540);
            panel3.Name = "panel3";
            panel3.Size = new Size(178, 92);
            panel3.TabIndex = 8;
            // 
            // NumPani
            // 
            NumPani.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            NumPani.AutoSize = true;
            NumPani.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            NumPani.Location = new Point(69, 50);
            NumPani.Name = "NumPani";
            NumPani.Size = new Size(34, 25);
            NumPani.TabIndex = 1;
            NumPani.Text = "00";
            NumPani.Click += NumPani_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(57, 13);
            label5.Name = "label5";
            label5.Size = new Size(68, 28);
            label5.TabIndex = 0;
            label5.Text = "PANI";
            label5.Click += label5_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(NumImas);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(1082, 540);
            panel4.Name = "panel4";
            panel4.Size = new Size(178, 92);
            panel4.TabIndex = 9;
            // 
            // NumImas
            // 
            NumImas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            NumImas.AutoSize = true;
            NumImas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            NumImas.Location = new Point(69, 50);
            NumImas.Name = "NumImas";
            NumImas.Size = new Size(34, 25);
            NumImas.TabIndex = 1;
            NumImas.Text = "00";
            NumImas.Click += label8_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(47, 13);
            label7.Name = "label7";
            label7.Size = new Size(71, 28);
            label7.TabIndex = 0;
            label7.Text = "IMAS";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel5.BackColor = SystemColors.ButtonHighlight;
            panel5.Controls.Add(NumPrivados);
            panel5.Controls.Add(label9);
            panel5.Location = new Point(1298, 540);
            panel5.Name = "panel5";
            panel5.Size = new Size(178, 92);
            panel5.TabIndex = 10;
            // 
            // NumPrivados
            // 
            NumPrivados.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            NumPrivados.AutoSize = true;
            NumPrivados.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            NumPrivados.Location = new Point(74, 50);
            NumPrivados.Name = "NumPrivados";
            NumPrivados.Size = new Size(34, 25);
            NumPrivados.TabIndex = 1;
            NumPrivados.Text = "00";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(25, 13);
            label9.Name = "label9";
            label9.Size = new Size(130, 28);
            label9.TabIndex = 0;
            label9.Text = "PRIVADOS";
            // 
            // comboBoxGrupos
            // 
            comboBoxGrupos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGrupos.FormattingEnabled = true;
            comboBoxGrupos.Location = new Point(17, 98);
            comboBoxGrupos.Name = "comboBoxGrupos";
            comboBoxGrupos.Size = new Size(208, 23);
            comboBoxGrupos.TabIndex = 11;
            comboBoxGrupos.SelectedIndexChanged += comboBoxGrupos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(17, 539);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 12;
            label2.Text = "Año :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(17, 580);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 13;
            label4.Text = "Maestra :";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(17, 616);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 14;
            label6.Text = "Asistente :";
            // 
            // anno
            // 
            anno.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            anno.AutoSize = true;
            anno.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            anno.Location = new Point(84, 539);
            anno.Name = "anno";
            anno.Size = new Size(45, 19);
            anno.TabIndex = 15;
            anno.Text = "0000";
            anno.Click += anno_Click;
            // 
            // labelNameDocente
            // 
            labelNameDocente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelNameDocente.AutoSize = true;
            labelNameDocente.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelNameDocente.Location = new Point(84, 580);
            labelNameDocente.Name = "labelNameDocente";
            labelNameDocente.Size = new Size(154, 19);
            labelNameDocente.TabIndex = 16;
            labelNameDocente.Text = "Nombre Completo";
            labelNameDocente.Click += labelNameDocente_Click;
            // 
            // labelNameAsistente
            // 
            labelNameAsistente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelNameAsistente.AutoSize = true;
            labelNameAsistente.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelNameAsistente.Location = new Point(84, 617);
            labelNameAsistente.Name = "labelNameAsistente";
            labelNameAsistente.Size = new Size(154, 19);
            labelNameAsistente.TabIndex = 17;
            labelNameAsistente.Text = "Nombre Completo";
            labelNameAsistente.Click += labelNameAsistente_Click;
            // 
            // buttonPdf
            // 
            buttonPdf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPdf.BackColor = Color.IndianRed;
            buttonPdf.FlatAppearance.BorderColor = Color.IndianRed;
            buttonPdf.FlatAppearance.BorderSize = 0;
            buttonPdf.FlatStyle = FlatStyle.Popup;
            buttonPdf.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPdf.ForeColor = SystemColors.ControlLightLight;
            buttonPdf.Location = new Point(1340, 90);
            buttonPdf.Name = "buttonPdf";
            buttonPdf.Size = new Size(136, 36);
            buttonPdf.TabIndex = 18;
            buttonPdf.Text = "PDF";
            buttonPdf.UseVisualStyleBackColor = false;
            buttonPdf.Click += buttonPdf_Click;
            // 
            // UserPadres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(buttonPdf);
            Controls.Add(labelNameAsistente);
            Controls.Add(labelNameDocente);
            Controls.Add(anno);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(comboBoxGrupos);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewGrupos);
            Controls.Add(labelnNameGrupo);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "UserPadres";
            Size = new Size(1491, 646);
            Load += UserPadres_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrupos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelnNameGrupo;
        private DataGridView dataGridViewGrupos;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label NumMujeres;
        private Label label1;
        private Label NumHombres;
        private Label label3;
        private Label NumPani;
        private Label label5;
        private Label NumImas;
        private Label label7;
        private Label NumPrivados;
        private Label label9;
        private ComboBox comboBoxGrupos;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label anno;
        private Label labelNameDocente;
        private Label labelNameAsistente;
        private Button buttonPdf;
    }
}
