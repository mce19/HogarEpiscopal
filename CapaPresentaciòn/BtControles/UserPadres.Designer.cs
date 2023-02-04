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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelnNameGrupo = new System.Windows.Forms.Label();
            this.dataGridViewGrupos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NumMujeres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NumHombres = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NumPani = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NumImas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NumPrivados = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxGrupos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelnNameGrupo
            // 
            this.labelnNameGrupo.AutoSize = true;
            this.labelnNameGrupo.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelnNameGrupo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelnNameGrupo.Location = new System.Drawing.Point(664, 18);
            this.labelnNameGrupo.Name = "labelnNameGrupo";
            this.labelnNameGrupo.Size = new System.Drawing.Size(171, 56);
            this.labelnNameGrupo.TabIndex = 4;
            this.labelnNameGrupo.Text = "Grupo";
            this.labelnNameGrupo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewGrupos
            // 
            this.dataGridViewGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGrupos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewGrupos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrupos.Location = new System.Drawing.Point(17, 140);
            this.dataGridViewGrupos.Name = "dataGridViewGrupos";
            this.dataGridViewGrupos.RowTemplate.Height = 25;
            this.dataGridViewGrupos.Size = new System.Drawing.Size(1459, 384);
            this.dataGridViewGrupos.TabIndex = 5;
            this.dataGridViewGrupos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGrupos_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.NumMujeres);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(185, 540);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 92);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // NumMujeres
            // 
            this.NumMujeres.AutoSize = true;
            this.NumMujeres.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumMujeres.Location = new System.Drawing.Point(61, 50);
            this.NumMujeres.Name = "NumMujeres";
            this.NumMujeres.Size = new System.Drawing.Size(34, 25);
            this.NumMujeres.TabIndex = 1;
            this.NumMujeres.Text = "00";
            this.NumMujeres.Click += new System.EventHandler(this.NumMujeres_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mujeres";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.NumHombres);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(410, 540);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 92);
            this.panel2.TabIndex = 7;
            // 
            // NumHombres
            // 
            this.NumHombres.AutoSize = true;
            this.NumHombres.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumHombres.Location = new System.Drawing.Point(67, 50);
            this.NumHombres.Name = "NumHombres";
            this.NumHombres.Size = new System.Drawing.Size(34, 25);
            this.NumHombres.TabIndex = 1;
            this.NumHombres.Text = "00";
            this.NumHombres.Click += new System.EventHandler(this.NumHombres_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hombres";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.NumPani);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(629, 540);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 92);
            this.panel3.TabIndex = 8;
            // 
            // NumPani
            // 
            this.NumPani.AutoSize = true;
            this.NumPani.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumPani.Location = new System.Drawing.Point(69, 50);
            this.NumPani.Name = "NumPani";
            this.NumPani.Size = new System.Drawing.Size(34, 25);
            this.NumPani.TabIndex = 1;
            this.NumPani.Text = "00";
            this.NumPani.Click += new System.EventHandler(this.NumPani_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(57, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "PANI";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.NumImas);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(847, 540);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 92);
            this.panel4.TabIndex = 9;
            // 
            // NumImas
            // 
            this.NumImas.AutoSize = true;
            this.NumImas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumImas.Location = new System.Drawing.Point(69, 50);
            this.NumImas.Name = "NumImas";
            this.NumImas.Size = new System.Drawing.Size(34, 25);
            this.NumImas.TabIndex = 1;
            this.NumImas.Text = "00";
            this.NumImas.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(47, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "IMAS";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.NumPrivados);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(1070, 540);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 92);
            this.panel5.TabIndex = 10;
            // 
            // NumPrivados
            // 
            this.NumPrivados.AutoSize = true;
            this.NumPrivados.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumPrivados.Location = new System.Drawing.Point(74, 50);
            this.NumPrivados.Name = "NumPrivados";
            this.NumPrivados.Size = new System.Drawing.Size(34, 25);
            this.NumPrivados.TabIndex = 1;
            this.NumPrivados.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(31, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "PRIVADOS";
            // 
            // comboBoxGrupos
            // 
            this.comboBoxGrupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrupos.FormattingEnabled = true;
            this.comboBoxGrupos.Location = new System.Drawing.Point(17, 98);
            this.comboBoxGrupos.Name = "comboBoxGrupos";
            this.comboBoxGrupos.Size = new System.Drawing.Size(208, 23);
            this.comboBoxGrupos.TabIndex = 11;
            this.comboBoxGrupos.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrupos_SelectedIndexChanged);
            // 
            // UserPadres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.comboBoxGrupos);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewGrupos);
            this.Controls.Add(this.labelnNameGrupo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "UserPadres";
            this.Size = new System.Drawing.Size(1491, 646);
            this.Load += new System.EventHandler(this.UserPadres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
