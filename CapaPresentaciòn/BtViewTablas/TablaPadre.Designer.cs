namespace CapaPresentaciòn.BtViewTablas
{
    partial class TablaPadre
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNunDocumento = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.TxtTitTablaPadre = new System.Windows.Forms.Label();
            this.maskedTextBoxDireccion = new System.Windows.Forms.MaskedTextBox();
            this.buttonGuardarPadre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Documento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre completo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(392, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direcciòn";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(392, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tèlefono";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxNunDocumento
            // 
            this.textBoxNunDocumento.Location = new System.Drawing.Point(40, 132);
            this.textBoxNunDocumento.Name = "textBoxNunDocumento";
            this.textBoxNunDocumento.Size = new System.Drawing.Size(309, 23);
            this.textBoxNunDocumento.TabIndex = 4;
            this.textBoxNunDocumento.TextChanged += new System.EventHandler(this.textBoxNunDocumento_TextChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(40, 217);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(309, 23);
            this.textBoxNombre.TabIndex = 5;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(392, 132);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(309, 23);
            this.textBoxTelefono.TabIndex = 6;
            this.textBoxTelefono.TextChanged += new System.EventHandler(this.textBoxTelefono_TextChanged);
            // 
            // TxtTitTablaPadre
            // 
            this.TxtTitTablaPadre.AutoSize = true;
            this.TxtTitTablaPadre.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtTitTablaPadre.Location = new System.Drawing.Point(291, 33);
            this.TxtTitTablaPadre.Name = "TxtTitTablaPadre";
            this.TxtTitTablaPadre.Size = new System.Drawing.Size(175, 28);
            this.TxtTitTablaPadre.TabIndex = 8;
            this.TxtTitTablaPadre.Text = "Nombre tabla";
            this.TxtTitTablaPadre.Click += new System.EventHandler(this.TxtTitTablaPadre_Click);
            // 
            // maskedTextBoxDireccion
            // 
            this.maskedTextBoxDireccion.Location = new System.Drawing.Point(392, 218);
            this.maskedTextBoxDireccion.Name = "maskedTextBoxDireccion";
            this.maskedTextBoxDireccion.Size = new System.Drawing.Size(309, 23);
            this.maskedTextBoxDireccion.TabIndex = 9;
            this.maskedTextBoxDireccion.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxDireccion_MaskInputRejected);
            // 
            // buttonGuardarPadre
            // 
            this.buttonGuardarPadre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGuardarPadre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGuardarPadre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGuardarPadre.Location = new System.Drawing.Point(588, 438);
            this.buttonGuardarPadre.Name = "buttonGuardarPadre";
            this.buttonGuardarPadre.Size = new System.Drawing.Size(126, 47);
            this.buttonGuardarPadre.TabIndex = 10;
            this.buttonGuardarPadre.Text = "Guardar";
            this.buttonGuardarPadre.UseVisualStyleBackColor = false;
            this.buttonGuardarPadre.Click += new System.EventHandler(this.buttonGuardarPadre_Click);
            // 
            // TablaPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 497);
            this.Controls.Add(this.buttonGuardarPadre);
            this.Controls.Add(this.maskedTextBoxDireccion);
            this.Controls.Add(this.TxtTitTablaPadre);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxNunDocumento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "TablaPadre";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "TablaPadre";
            this.Load += new System.EventHandler(this.TablaPadre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxNunDocumento;
        private TextBox textBoxNombre;
        private TextBox textBoxTelefono;
        private Label TxtTitTablaPadre;
        private MaskedTextBox maskedTextBoxDireccion;
        private Button buttonGuardarPadre;
    }
}