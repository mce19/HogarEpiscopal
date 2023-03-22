namespace CapaPresentaciòn.BtControles
{
    partial class UserHistorial
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewHistorial = new DataGridView();
            label1 = new Label();
            buttonFactura = new Button();
            textBoxBuscador = new TextBox();
            label2 = new Label();
            panelE = new Panel();
            NumExtranjero = new Label();
            SumaHistorial = new Label();
            BoxMes = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorial).BeginInit();
            panelE.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewHistorial
            // 
            dataGridViewHistorial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHistorial.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewHistorial.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewHistorial.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistorial.GridColor = Color.FromArgb(255, 128, 0);
            dataGridViewHistorial.Location = new Point(33, 126);
            dataGridViewHistorial.Name = "dataGridViewHistorial";
            dataGridViewHistorial.RowTemplate.Height = 25;
            dataGridViewHistorial.Size = new Size(1439, 378);
            dataGridViewHistorial.TabIndex = 5;
            dataGridViewHistorial.CellContentClick += dataGridViewHistorial_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(585, 32);
            label1.Name = "label1";
            label1.Size = new Size(303, 38);
            label1.TabIndex = 6;
            label1.Text = "Historial de pagos ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonFactura
            // 
            buttonFactura.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonFactura.BackColor = Color.FromArgb(0, 192, 0);
            buttonFactura.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFactura.ForeColor = Color.White;
            buttonFactura.Location = new Point(1310, 551);
            buttonFactura.Name = "buttonFactura";
            buttonFactura.Size = new Size(162, 44);
            buttonFactura.TabIndex = 7;
            buttonFactura.Text = "boton";
            buttonFactura.UseVisualStyleBackColor = false;
            buttonFactura.Click += buttonFactura_Click;
            // 
            // textBoxBuscador
            // 
            textBoxBuscador.BackColor = SystemColors.InactiveBorder;
            textBoxBuscador.Location = new Point(195, 88);
            textBoxBuscador.Name = "textBoxBuscador";
            textBoxBuscador.Size = new Size(629, 23);
            textBoxBuscador.TabIndex = 9;
            textBoxBuscador.TextChanged += textBoxBuscador_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 87);
            label2.Name = "label2";
            label2.Size = new Size(156, 19);
            label2.TabIndex = 12;
            label2.Text = "Buscar por nombre";
            // 
            // panelE
            // 
            panelE.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelE.BackColor = SystemColors.GradientActiveCaption;
            panelE.Controls.Add(NumExtranjero);
            panelE.Controls.Add(SumaHistorial);
            panelE.Location = new Point(33, 522);
            panelE.Name = "panelE";
            panelE.Size = new Size(186, 92);
            panelE.TabIndex = 13;
            // 
            // NumExtranjero
            // 
            NumExtranjero.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            NumExtranjero.AutoSize = true;
            NumExtranjero.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            NumExtranjero.ForeColor = SystemColors.ButtonHighlight;
            NumExtranjero.Location = new Point(11, 48);
            NumExtranjero.Name = "NumExtranjero";
            NumExtranjero.Size = new Size(34, 25);
            NumExtranjero.TabIndex = 1;
            NumExtranjero.Text = "00";
            NumExtranjero.Click += NumExtranjero_Click;
            // 
            // SumaHistorial
            // 
            SumaHistorial.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SumaHistorial.AutoSize = true;
            SumaHistorial.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SumaHistorial.ForeColor = SystemColors.Highlight;
            SumaHistorial.Location = new Point(11, 14);
            SumaHistorial.Name = "SumaHistorial";
            SumaHistorial.Size = new Size(164, 28);
            SumaHistorial.TabIndex = 0;
            SumaHistorial.Text = "Mensualidad";
            // 
            // BoxMes
            // 
            BoxMes.DropDownStyle = ComboBoxStyle.DropDownList;
            BoxMes.FormattingEnabled = true;
            BoxMes.Location = new Point(843, 88);
            BoxMes.Name = "BoxMes";
            BoxMes.Size = new Size(189, 23);
            BoxMes.TabIndex = 14;
            BoxMes.SelectedIndexChanged += BoxMes_SelectedIndexChanged;
            // 
            // UserHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BoxMes);
            Controls.Add(panelE);
            Controls.Add(label2);
            Controls.Add(textBoxBuscador);
            Controls.Add(buttonFactura);
            Controls.Add(label1);
            Controls.Add(dataGridViewHistorial);
            Name = "UserHistorial";
            Size = new Size(1491, 646);
            Load += UserHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorial).EndInit();
            panelE.ResumeLayout(false);
            panelE.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewHistorial;
        private Label label1;
        private Button buttonFactura;
        private TextBox textBoxBuscador;
        private Label label2;
        private Panel panelE;
        private Label NumExtranjero;
        private Label SumaHistorial;
        private ComboBox BoxMes;
    }
}
