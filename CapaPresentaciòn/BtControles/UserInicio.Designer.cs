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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTablaSeleccionada = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbTablas = new System.Windows.Forms.ComboBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.buttonPagar = new System.Windows.Forms.Button();
            this.NumNacional = new System.Windows.Forms.Label();
            this.panelN = new System.Windows.Forms.Panel();
            this.labelN = new System.Windows.Forms.Label();
            this.NumExtranjero = new System.Windows.Forms.Label();
            this.panelE = new System.Windows.Forms.Panel();
            this.labelE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelN.SuspendLayout();
            this.panelE.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTablaSeleccionada
            // 
            this.lblTablaSeleccionada.AutoSize = true;
            this.lblTablaSeleccionada.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTablaSeleccionada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTablaSeleccionada.Location = new System.Drawing.Point(640, 19);
            this.lblTablaSeleccionada.Name = "lblTablaSeleccionada";
            this.lblTablaSeleccionada.Size = new System.Drawing.Size(130, 44);
            this.lblTablaSeleccionada.TabIndex = 2;
            this.lblTablaSeleccionada.Text = "Datos ";
            this.lblTablaSeleccionada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTablaSeleccionada.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(204, 135);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 387);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmbTablas
            // 
            this.cmbTablas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Location = new System.Drawing.Point(204, 84);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(196, 28);
            this.cmbTablas.TabIndex = 4;
            this.cmbTablas.SelectedIndexChanged += new System.EventHandler(this.cmbTablas_SelectedIndexChanged);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Location = new System.Drawing.Point(910, 558);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(99, 40);
            this.buttonEditar.TabIndex = 5;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(1034, 558);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(99, 40);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNuevo.ForeColor = System.Drawing.Color.White;
            this.buttonNuevo.Location = new System.Drawing.Point(1155, 558);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(99, 40);
            this.buttonNuevo.TabIndex = 7;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = false;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxBuscador.Location = new System.Drawing.Point(430, 86);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(824, 26);
            this.textBoxBuscador.TabIndex = 8;
            this.textBoxBuscador.TextChanged += new System.EventHandler(this.textBoxBuscador_TextChanged);
            // 
            // buttonPagar
            // 
            this.buttonPagar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPagar.ForeColor = System.Drawing.Color.White;
            this.buttonPagar.Location = new System.Drawing.Point(785, 558);
            this.buttonPagar.Name = "buttonPagar";
            this.buttonPagar.Size = new System.Drawing.Size(99, 40);
            this.buttonPagar.TabIndex = 9;
            this.buttonPagar.Text = "Abonar";
            this.buttonPagar.UseVisualStyleBackColor = false;
            this.buttonPagar.Visible = false;
            this.buttonPagar.Click += new System.EventHandler(this.buttonPagar_Click);
            // 
            // NumNacional
            // 
            this.NumNacional.AutoSize = true;
            this.NumNacional.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumNacional.Location = new System.Drawing.Point(61, 50);
            this.NumNacional.Name = "NumNacional";
            this.NumNacional.Size = new System.Drawing.Size(34, 25);
            this.NumNacional.TabIndex = 1;
            this.NumNacional.Text = "00";
            this.NumNacional.Click += new System.EventHandler(this.NumNacional_Click);
            // 
            // panelN
            // 
            this.panelN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelN.Controls.Add(this.NumNacional);
            this.panelN.Controls.Add(this.labelN);
            this.panelN.Location = new System.Drawing.Point(204, 541);
            this.panelN.Name = "panelN";
            this.panelN.Size = new System.Drawing.Size(178, 92);
            this.panelN.TabIndex = 10;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelN.Location = new System.Drawing.Point(33, 13);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(118, 28);
            this.labelN.TabIndex = 0;
            this.labelN.Text = "Nacional";
            // 
            // NumExtranjero
            // 
            this.NumExtranjero.AutoSize = true;
            this.NumExtranjero.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumExtranjero.Location = new System.Drawing.Point(61, 50);
            this.NumExtranjero.Name = "NumExtranjero";
            this.NumExtranjero.Size = new System.Drawing.Size(34, 25);
            this.NumExtranjero.TabIndex = 1;
            this.NumExtranjero.Text = "00";
            this.NumExtranjero.Click += new System.EventHandler(this.NumExtranjero_Click);
            // 
            // panelE
            // 
            this.panelE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelE.Controls.Add(this.NumExtranjero);
            this.panelE.Controls.Add(this.labelE);
            this.panelE.Location = new System.Drawing.Point(403, 541);
            this.panelE.Name = "panelE";
            this.panelE.Size = new System.Drawing.Size(178, 92);
            this.panelE.TabIndex = 7;
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelE.Location = new System.Drawing.Point(27, 13);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(126, 28);
            this.labelE.TabIndex = 0;
            this.labelE.Text = "Extranjero";
            // 
            // UserInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelE);
            this.Controls.Add(this.panelN);
            this.Controls.Add(this.buttonPagar);
            this.Controls.Add(this.textBoxBuscador);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.cmbTablas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTablaSeleccionada);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserInicio";
            this.Size = new System.Drawing.Size(1491, 646);
            this.Load += new System.EventHandler(this.UserInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelN.ResumeLayout(false);
            this.panelN.PerformLayout();
            this.panelE.ResumeLayout(false);
            this.panelE.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
