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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxNunDocumento = new TextBox();
            textBoxNombre = new TextBox();
            textBoxTelefono = new TextBox();
            TxtTitTablaPadre = new Label();
            maskedTextBoxDireccion = new MaskedTextBox();
            buttonGuardarPadre = new Button();
            label5 = new Label();
            buttonCancelarPago = new Button();
            textBoxTipoDucumento = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 196);
            label1.Name = "label1";
            label1.Size = new Size(167, 19);
            label1.TabIndex = 0;
            label1.Text = "Numero Documento";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 281);
            label2.Name = "label2";
            label2.Size = new Size(152, 19);
            label2.TabIndex = 1;
            label2.Text = "Nombre completo";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(392, 196);
            label3.Name = "label3";
            label3.Size = new Size(83, 19);
            label3.TabIndex = 2;
            label3.Text = "Direcciòn";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(392, 110);
            label4.Name = "label4";
            label4.Size = new Size(74, 19);
            label4.TabIndex = 3;
            label4.Text = "Tèlefono";
            label4.Click += label4_Click;
            // 
            // textBoxNunDocumento
            // 
            textBoxNunDocumento.Location = new Point(39, 218);
            textBoxNunDocumento.Name = "textBoxNunDocumento";
            textBoxNunDocumento.Size = new Size(309, 23);
            textBoxNunDocumento.TabIndex = 4;
            textBoxNunDocumento.TextChanged += textBoxNunDocumento_TextChanged;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(39, 303);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(309, 23);
            textBoxNombre.TabIndex = 5;
            textBoxNombre.TextChanged += textBox2_TextChanged;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(392, 132);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(309, 23);
            textBoxTelefono.TabIndex = 6;
            textBoxTelefono.TextChanged += textBoxTelefono_TextChanged;
            // 
            // TxtTitTablaPadre
            // 
            TxtTitTablaPadre.AutoSize = true;
            TxtTitTablaPadre.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TxtTitTablaPadre.Location = new Point(291, 33);
            TxtTitTablaPadre.Name = "TxtTitTablaPadre";
            TxtTitTablaPadre.Size = new Size(175, 28);
            TxtTitTablaPadre.TabIndex = 8;
            TxtTitTablaPadre.Text = "Nombre tabla";
            TxtTitTablaPadre.Click += TxtTitTablaPadre_Click;
            // 
            // maskedTextBoxDireccion
            // 
            maskedTextBoxDireccion.Location = new Point(392, 218);
            maskedTextBoxDireccion.Name = "maskedTextBoxDireccion";
            maskedTextBoxDireccion.Size = new Size(309, 23);
            maskedTextBoxDireccion.TabIndex = 9;
            maskedTextBoxDireccion.MaskInputRejected += maskedTextBoxDireccion_MaskInputRejected;
            // 
            // buttonGuardarPadre
            // 
            buttonGuardarPadre.BackColor = SystemColors.ActiveCaption;
            buttonGuardarPadre.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGuardarPadre.ForeColor = SystemColors.ControlLightLight;
            buttonGuardarPadre.Location = new Point(588, 438);
            buttonGuardarPadre.Name = "buttonGuardarPadre";
            buttonGuardarPadre.Size = new Size(126, 47);
            buttonGuardarPadre.TabIndex = 10;
            buttonGuardarPadre.Text = "Guardar";
            buttonGuardarPadre.UseVisualStyleBackColor = false;
            buttonGuardarPadre.Click += buttonGuardarPadre_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(39, 110);
            label5.Name = "label5";
            label5.Size = new Size(161, 19);
            label5.TabIndex = 12;
            label5.Text = "Tipo de documento";
            // 
            // buttonCancelarPago
            // 
            buttonCancelarPago.BackColor = Color.Red;
            buttonCancelarPago.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelarPago.ForeColor = Color.White;
            buttonCancelarPago.Location = new Point(462, 438);
            buttonCancelarPago.Name = "buttonCancelarPago";
            buttonCancelarPago.Size = new Size(120, 47);
            buttonCancelarPago.TabIndex = 51;
            buttonCancelarPago.Text = "Cancelar";
            buttonCancelarPago.UseVisualStyleBackColor = false;
            buttonCancelarPago.Click += buttonCancelarPago_Click;
            // 
            // textBoxTipoDucumento
            // 
            textBoxTipoDucumento.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxTipoDucumento.FormattingEnabled = true;
            textBoxTipoDucumento.Location = new Point(39, 132);
            textBoxTipoDucumento.Name = "textBoxTipoDucumento";
            textBoxTipoDucumento.Size = new Size(190, 23);
            textBoxTipoDucumento.TabIndex = 52;
            textBoxTipoDucumento.SelectedIndexChanged += textBoxTipoDucumento_SelectedIndexChanged;
            // 
            // TablaPadre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 489);
            ControlBox = false;
            Controls.Add(textBoxTipoDucumento);
            Controls.Add(buttonCancelarPago);
            Controls.Add(label5);
            Controls.Add(buttonGuardarPadre);
            Controls.Add(maskedTextBoxDireccion);
            Controls.Add(TxtTitTablaPadre);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxNunDocumento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "TablaPadre";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TablaPadre";
            TopMost = true;
            Load += TablaPadre_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private Label label5;
        private Button buttonCancelarPago;
        private ComboBox textBoxTipoDucumento;
    }
}