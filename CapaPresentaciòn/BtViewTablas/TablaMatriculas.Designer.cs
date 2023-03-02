namespace CapaPresentaciòn.BtViewTablas
{
    partial class TablaMatriculas
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
            this.buttonCancelarPago = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGrupoMatricula = new System.Windows.Forms.TextBox();
            this.buttonGuardaDocente = new System.Windows.Forms.Button();
            this.TextBoxDireccionMatricula = new System.Windows.Forms.MaskedTextBox();
            this.TxtTitTablaMatricula = new System.Windows.Forms.Label();
            this.textBoxTelefonoMatricula = new System.Windows.Forms.TextBox();
            this.textBoxNombreMatricula = new System.Windows.Forms.TextBox();
            this.textBoxNunMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelarPago
            // 
            this.buttonCancelarPago.BackColor = System.Drawing.Color.Red;
            this.buttonCancelarPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelarPago.ForeColor = System.Drawing.Color.White;
            this.buttonCancelarPago.Location = new System.Drawing.Point(446, 432);
            this.buttonCancelarPago.Name = "buttonCancelarPago";
            this.buttonCancelarPago.Size = new System.Drawing.Size(120, 47);
            this.buttonCancelarPago.TabIndex = 77;
            this.buttonCancelarPago.Text = "Cancelar";
            this.buttonCancelarPago.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(376, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 76;
            this.label5.Text = "Grupo ID";
            // 
            // textBoxGrupoMatricula
            // 
            this.textBoxGrupoMatricula.Location = new System.Drawing.Point(376, 211);
            this.textBoxGrupoMatricula.Name = "textBoxGrupoMatricula";
            this.textBoxGrupoMatricula.Size = new System.Drawing.Size(309, 23);
            this.textBoxGrupoMatricula.TabIndex = 75;
            this.textBoxGrupoMatricula.TextChanged += new System.EventHandler(this.textBoxGrupoMatricula_TextChanged);
            // 
            // buttonGuardaDocente
            // 
            this.buttonGuardaDocente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGuardaDocente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGuardaDocente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGuardaDocente.Location = new System.Drawing.Point(572, 432);
            this.buttonGuardaDocente.Name = "buttonGuardaDocente";
            this.buttonGuardaDocente.Size = new System.Drawing.Size(126, 47);
            this.buttonGuardaDocente.TabIndex = 74;
            this.buttonGuardaDocente.Text = "Guardar";
            this.buttonGuardaDocente.UseVisualStyleBackColor = false;
            // 
            // TextBoxDireccionMatricula
            // 
            this.TextBoxDireccionMatricula.Location = new System.Drawing.Point(43, 297);
            this.TextBoxDireccionMatricula.Name = "TextBoxDireccionMatricula";
            this.TextBoxDireccionMatricula.Size = new System.Drawing.Size(309, 23);
            this.TextBoxDireccionMatricula.TabIndex = 73;
            this.TextBoxDireccionMatricula.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TextBoxDireccionMatricula_MaskInputRejected);
            // 
            // TxtTitTablaMatricula
            // 
            this.TxtTitTablaMatricula.AutoSize = true;
            this.TxtTitTablaMatricula.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtTitTablaMatricula.Location = new System.Drawing.Point(275, 27);
            this.TxtTitTablaMatricula.Name = "TxtTitTablaMatricula";
            this.TxtTitTablaMatricula.Size = new System.Drawing.Size(175, 28);
            this.TxtTitTablaMatricula.TabIndex = 72;
            this.TxtTitTablaMatricula.Text = "Nombre tabla";
            // 
            // textBoxTelefonoMatricula
            // 
            this.textBoxTelefonoMatricula.Location = new System.Drawing.Point(376, 126);
            this.textBoxTelefonoMatricula.Name = "textBoxTelefonoMatricula";
            this.textBoxTelefonoMatricula.Size = new System.Drawing.Size(309, 23);
            this.textBoxTelefonoMatricula.TabIndex = 71;
            this.textBoxTelefonoMatricula.TextChanged += new System.EventHandler(this.textBoxTelefonoMatricula_TextChanged);
            // 
            // textBoxNombreMatricula
            // 
            this.textBoxNombreMatricula.Location = new System.Drawing.Point(43, 211);
            this.textBoxNombreMatricula.Name = "textBoxNombreMatricula";
            this.textBoxNombreMatricula.Size = new System.Drawing.Size(309, 23);
            this.textBoxNombreMatricula.TabIndex = 70;
            this.textBoxNombreMatricula.TextChanged += new System.EventHandler(this.textBoxNombreMatricula_TextChanged);
            // 
            // textBoxNunMatricula
            // 
            this.textBoxNunMatricula.Location = new System.Drawing.Point(43, 126);
            this.textBoxNunMatricula.Name = "textBoxNunMatricula";
            this.textBoxNunMatricula.Size = new System.Drawing.Size(309, 23);
            this.textBoxNunMatricula.TabIndex = 69;
            this.textBoxNunMatricula.TextChanged += new System.EventHandler(this.textBoxNunMatricula_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(376, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 68;
            this.label4.Text = "Ced. Docente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(43, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 67;
            this.label3.Text = "Ced. Padre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "Ced. Hijo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 65;
            this.label1.Text = "ID";
            // 
            // TablaMatriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 497);
            this.Controls.Add(this.buttonCancelarPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxGrupoMatricula);
            this.Controls.Add(this.buttonGuardaDocente);
            this.Controls.Add(this.TextBoxDireccionMatricula);
            this.Controls.Add(this.TxtTitTablaMatricula);
            this.Controls.Add(this.textBoxTelefonoMatricula);
            this.Controls.Add(this.textBoxNombreMatricula);
            this.Controls.Add(this.textBoxNunMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TablaMatriculas";
            this.Text = "TablaMatriculas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCancelarPago;
        private Label label5;
        private TextBox textBoxGrupoMatricula;
        private Button buttonGuardaDocente;
        private MaskedTextBox TextBoxDireccionMatricula;
        private Label TxtTitTablaMatricula;
        private TextBox textBoxTelefonoMatricula;
        private TextBox textBoxNombreMatricula;
        private TextBox textBoxNunMatricula;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}