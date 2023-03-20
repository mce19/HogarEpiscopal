namespace CapaPresentaciòn.BtControles
{
    partial class UserInicio
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTablaSeleccionada = new Label();
            dataGridView1 = new DataGridView();
            cmbTablas = new ComboBox();
            buttonEditar = new Button();
            buttonEliminar = new Button();
            buttonNuevo = new Button();
            textBoxBuscador = new TextBox();
            buttonPagar = new Button();
            NumNacional = new Label();
            panelN = new Panel();
            labelN = new Label();
            NumExtranjero = new Label();
            panelE = new Panel();
            labelE = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelN.SuspendLayout();
            panelE.SuspendLayout();
            SuspendLayout();
            // 
            // lblTablaSeleccionada
            // 
            lblTablaSeleccionada.AutoSize = true;
            lblTablaSeleccionada.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTablaSeleccionada.ForeColor = SystemColors.ActiveCaptionText;
            lblTablaSeleccionada.Location = new Point(640, 19);
            lblTablaSeleccionada.Name = "lblTablaSeleccionada";
            lblTablaSeleccionada.Size = new Size(130, 44);
            lblTablaSeleccionada.TabIndex = 2;
            lblTablaSeleccionada.Text = "Datos ";
            lblTablaSeleccionada.TextAlign = ContentAlignment.TopCenter;
            lblTablaSeleccionada.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.FromArgb(255, 128, 0);
            dataGridView1.Location = new Point(204, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1050, 387);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cmbTablas
            // 
            cmbTablas.BackColor = SystemColors.InactiveCaption;
            cmbTablas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTablas.FormattingEnabled = true;
            cmbTablas.Location = new Point(204, 84);
            cmbTablas.Name = "cmbTablas";
            cmbTablas.Size = new Size(196, 28);
            cmbTablas.TabIndex = 4;
            cmbTablas.SelectedIndexChanged += cmbTablas_SelectedIndexChanged;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEditar.BackColor = Color.LimeGreen;
            buttonEditar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditar.ForeColor = Color.White;
            buttonEditar.Location = new Point(910, 558);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(99, 40);
            buttonEditar.TabIndex = 5;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEliminar.BackColor = Color.DarkGoldenrod;
            buttonEliminar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEliminar.ForeColor = Color.White;
            buttonEliminar.Location = new Point(1034, 558);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(99, 40);
            buttonEliminar.TabIndex = 6;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonNuevo.BackColor = SystemColors.HotTrack;
            buttonNuevo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNuevo.ForeColor = Color.White;
            buttonNuevo.Location = new Point(1155, 558);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(99, 40);
            buttonNuevo.TabIndex = 7;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = false;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // textBoxBuscador
            // 
            textBoxBuscador.BackColor = SystemColors.InactiveBorder;
            textBoxBuscador.Location = new Point(430, 86);
            textBoxBuscador.Name = "textBoxBuscador";
            textBoxBuscador.Size = new Size(824, 26);
            textBoxBuscador.TabIndex = 8;
            textBoxBuscador.TextChanged += textBoxBuscador_TextChanged;
            // 
            // buttonPagar
            // 
            buttonPagar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonPagar.BackColor = SystemColors.ActiveCaption;
            buttonPagar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPagar.ForeColor = Color.White;
            buttonPagar.Location = new Point(785, 558);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(99, 40);
            buttonPagar.TabIndex = 9;
            buttonPagar.Text = "Abonar";
            buttonPagar.UseVisualStyleBackColor = false;
            buttonPagar.Visible = false;
            buttonPagar.Click += buttonPagar_Click;
            // 
            // NumNacional
            // 
            NumNacional.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            NumNacional.AutoSize = true;
            NumNacional.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            NumNacional.Location = new Point(61, 50);
            NumNacional.Name = "NumNacional";
            NumNacional.Size = new Size(34, 25);
            NumNacional.TabIndex = 1;
            NumNacional.Text = "00";
            NumNacional.Click += NumNacional_Click;
            // 
            // panelN
            // 
            panelN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelN.BackColor = SystemColors.ButtonHighlight;
            panelN.Controls.Add(NumNacional);
            panelN.Controls.Add(labelN);
            panelN.Location = new Point(204, 541);
            panelN.Name = "panelN";
            panelN.Size = new Size(178, 92);
            panelN.TabIndex = 10;
            // 
            // labelN
            // 
            labelN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelN.AutoSize = true;
            labelN.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelN.Location = new Point(33, 13);
            labelN.Name = "labelN";
            labelN.Size = new Size(118, 28);
            labelN.TabIndex = 0;
            labelN.Text = "Nacional";
            // 
            // NumExtranjero
            // 
            NumExtranjero.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            NumExtranjero.AutoSize = true;
            NumExtranjero.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            NumExtranjero.Location = new Point(61, 50);
            NumExtranjero.Name = "NumExtranjero";
            NumExtranjero.Size = new Size(34, 25);
            NumExtranjero.TabIndex = 1;
            NumExtranjero.Text = "00";
            NumExtranjero.Click += NumExtranjero_Click;
            // 
            // panelE
            // 
            panelE.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelE.BackColor = SystemColors.ButtonHighlight;
            panelE.Controls.Add(NumExtranjero);
            panelE.Controls.Add(labelE);
            panelE.Location = new Point(403, 541);
            panelE.Name = "panelE";
            panelE.Size = new Size(178, 92);
            panelE.TabIndex = 7;
            // 
            // labelE
            // 
            labelE.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelE.AutoSize = true;
            labelE.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelE.Location = new Point(27, 13);
            labelE.Name = "labelE";
            labelE.Size = new Size(126, 28);
            labelE.TabIndex = 0;
            labelE.Text = "Extranjero";
            // 
            // UserInicio
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelE);
            Controls.Add(panelN);
            Controls.Add(buttonPagar);
            Controls.Add(textBoxBuscador);
            Controls.Add(buttonNuevo);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonEditar);
            Controls.Add(cmbTablas);
            Controls.Add(dataGridView1);
            Controls.Add(lblTablaSeleccionada);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "UserInicio";
            Size = new Size(1491, 646);
            Load += UserInicio_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelN.ResumeLayout(false);
            panelN.PerformLayout();
            panelE.ResumeLayout(false);
            panelE.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTablaSeleccionada;
        private DataGridView dataGridView1;
        private ComboBox cmbTablas;
        private Button buttonEditar;
        private Button buttonEliminar;
        private Button buttonNuevo;
        private TextBox textBoxBuscador;
        private Button buttonPagar;
        private Label NumNacional;
        private Panel panelN;
        private Label labelN;
        private Label NumExtranjero;
        private Panel panelE;
        private Label labelE;
    }
}
