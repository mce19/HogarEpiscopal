namespace CapaPresentaciòn.BtViewTablas
{
    partial class TablaDocentes
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGrupoDocente = new System.Windows.Forms.TextBox();
            this.buttonGuardaDocente = new System.Windows.Forms.Button();
            this.TextBoxDireccionDocente = new System.Windows.Forms.MaskedTextBox();
            this.TxtTitTablaPadre = new System.Windows.Forms.Label();
            this.textBoxTelefonoDocente = new System.Windows.Forms.TextBox();
            this.textBoxNombreDocente = new System.Windows.Forms.TextBox();
            this.textBoxNunDocente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Red;
            this.buttonCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(449, 427);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(120, 47);
            this.buttonCancelar.TabIndex = 64;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(379, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 63;
            this.label5.Text = "Grupo ID";
            // 
            // textBoxGrupoDocente
            // 
            this.textBoxGrupoDocente.Location = new System.Drawing.Point(379, 206);
            this.textBoxGrupoDocente.Name = "textBoxGrupoDocente";
            this.textBoxGrupoDocente.Size = new System.Drawing.Size(309, 23);
            this.textBoxGrupoDocente.TabIndex = 62;
            this.textBoxGrupoDocente.TextChanged += new System.EventHandler(this.textBoxGrupoDocente_TextChanged);
            // 
            // buttonGuardaDocente
            // 
            this.buttonGuardaDocente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGuardaDocente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGuardaDocente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGuardaDocente.Location = new System.Drawing.Point(575, 427);
            this.buttonGuardaDocente.Name = "buttonGuardaDocente";
            this.buttonGuardaDocente.Size = new System.Drawing.Size(126, 47);
            this.buttonGuardaDocente.TabIndex = 61;
            this.buttonGuardaDocente.Text = "Guardar";
            this.buttonGuardaDocente.UseVisualStyleBackColor = false;
            this.buttonGuardaDocente.Click += new System.EventHandler(this.buttonGuardaDocente_Click);
            // 
            // TextBoxDireccionDocente
            // 
            this.TextBoxDireccionDocente.Location = new System.Drawing.Point(46, 292);
            this.TextBoxDireccionDocente.Name = "TextBoxDireccionDocente";
            this.TextBoxDireccionDocente.Size = new System.Drawing.Size(309, 23);
            this.TextBoxDireccionDocente.TabIndex = 60;
            this.TextBoxDireccionDocente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TextBoxDireccionDocente_MaskInputRejected);
            // 
            // TxtTitTablaPadre
            // 
            this.TxtTitTablaPadre.AutoSize = true;
            this.TxtTitTablaPadre.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtTitTablaPadre.Location = new System.Drawing.Point(278, 22);
            this.TxtTitTablaPadre.Name = "TxtTitTablaPadre";
            this.TxtTitTablaPadre.Size = new System.Drawing.Size(175, 28);
            this.TxtTitTablaPadre.TabIndex = 59;
            this.TxtTitTablaPadre.Text = "Nombre tabla";
            // 
            // textBoxTelefonoDocente
            // 
            this.textBoxTelefonoDocente.Location = new System.Drawing.Point(379, 121);
            this.textBoxTelefonoDocente.Name = "textBoxTelefonoDocente";
            this.textBoxTelefonoDocente.Size = new System.Drawing.Size(309, 23);
            this.textBoxTelefonoDocente.TabIndex = 58;
            this.textBoxTelefonoDocente.TextChanged += new System.EventHandler(this.textBoxTelefonoDocente_TextChanged);
            // 
            // textBoxNombreDocente
            // 
            this.textBoxNombreDocente.Location = new System.Drawing.Point(46, 206);
            this.textBoxNombreDocente.Name = "textBoxNombreDocente";
            this.textBoxNombreDocente.Size = new System.Drawing.Size(309, 23);
            this.textBoxNombreDocente.TabIndex = 57;
            this.textBoxNombreDocente.TextChanged += new System.EventHandler(this.textBoxNombreDocente_TextChanged);
            // 
            // textBoxNunDocente
            // 
            this.textBoxNunDocente.Location = new System.Drawing.Point(46, 121);
            this.textBoxNunDocente.Name = "textBoxNunDocente";
            this.textBoxNunDocente.Size = new System.Drawing.Size(309, 23);
            this.textBoxNunDocente.TabIndex = 56;
            this.textBoxNunDocente.TextChanged += new System.EventHandler(this.textBoxNunDocente_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(379, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 55;
            this.label4.Text = "Tèlefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 54;
            this.label3.Text = "Direcciòn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "Nombre completo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 19);
            this.label1.TabIndex = 52;
            this.label1.Text = "Numero Documento";
            // 
            // TablaDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 497);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxGrupoDocente);
            this.Controls.Add(this.buttonGuardaDocente);
            this.Controls.Add(this.TextBoxDireccionDocente);
            this.Controls.Add(this.TxtTitTablaPadre);
            this.Controls.Add(this.textBoxTelefonoDocente);
            this.Controls.Add(this.textBoxNombreDocente);
            this.Controls.Add(this.textBoxNunDocente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TablaDocentes";
            this.Text = "TablaDocentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCancelar;
        private Label label5;
        private TextBox textBoxGrupoDocente;
        private Button buttonGuardaDocente;
        private MaskedTextBox TextBoxDireccionDocente;
        private Label TxtTitTablaPadre;
        private TextBox textBoxTelefonoDocente;
        private TextBox textBoxNombreDocente;
        private TextBox textBoxNunDocente;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}