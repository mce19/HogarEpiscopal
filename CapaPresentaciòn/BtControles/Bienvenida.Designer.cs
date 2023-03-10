namespace CapaPresentaciòn.BtControles
{
    partial class Bienvenida
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPágos = new System.Windows.Forms.DataGridView();
            this.buttonNewAbono = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPágos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(573, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pagos por cancelar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewPágos
            // 
            this.dataGridViewPágos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPágos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPágos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPágos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPágos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPágos.Location = new System.Drawing.Point(29, 143);
            this.dataGridViewPágos.Name = "dataGridViewPágos";
            this.dataGridViewPágos.RowTemplate.Height = 25;
            this.dataGridViewPágos.Size = new System.Drawing.Size(1439, 378);
            this.dataGridViewPágos.TabIndex = 4;
            this.dataGridViewPágos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPágos_CellContentClick);
            // 
            // buttonNewAbono
            // 
            this.buttonNewAbono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonNewAbono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNewAbono.ForeColor = System.Drawing.Color.White;
            this.buttonNewAbono.Location = new System.Drawing.Point(1332, 556);
            this.buttonNewAbono.Name = "buttonNewAbono";
            this.buttonNewAbono.Size = new System.Drawing.Size(136, 44);
            this.buttonNewAbono.TabIndex = 5;
            this.buttonNewAbono.Text = "Abonar";
            this.buttonNewAbono.UseVisualStyleBackColor = false;
            this.buttonNewAbono.Click += new System.EventHandler(this.buttonNewAbono_Click);
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonNewAbono);
            this.Controls.Add(this.dataGridViewPágos);
            this.Controls.Add(this.label1);
            this.Name = "Bienvenida";
            this.Size = new System.Drawing.Size(1491, 646);
            this.Load += new System.EventHandler(this.Bienvenida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPágos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewPágos;
        private Button buttonNewAbono;
    }
}
