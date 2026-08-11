namespace Proyeto_Medicios_de_LLuvia
{
    partial class FormRegistro
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
            this.txtNuevoUser = new System.Windows.Forms.TextBox();
            this.txtNuevoPais = new System.Windows.Forms.TextBox();
            this.txtNuevaPass = new System.Windows.Forms.TextBox();
            this.btnGuardarRegistro = new System.Windows.Forms.Button();
            this.cmbRo1 = new System.Windows.Forms.ComboBox();
            this.chkAlta = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.chkBuscar = new System.Windows.Forms.CheckBox();
            this.chkLista = new System.Windows.Forms.CheckBox();
            this.chkModificar = new System.Windows.Forms.CheckBox();
            this.chkBaja = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNuevoUser
            // 
            this.txtNuevoUser.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNuevoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoUser.Location = new System.Drawing.Point(70, 230);
            this.txtNuevoUser.Name = "txtNuevoUser";
            this.txtNuevoUser.Size = new System.Drawing.Size(189, 21);
            this.txtNuevoUser.TabIndex = 3;
            this.txtNuevoUser.Leave += new System.EventHandler(this.txtNuevoUser_Leave);
            // 
            // txtNuevoPais
            // 
            this.txtNuevoPais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNuevoPais.Location = new System.Drawing.Point(70, 356);
            this.txtNuevoPais.Name = "txtNuevoPais";
            this.txtNuevoPais.Size = new System.Drawing.Size(189, 13);
            this.txtNuevoPais.TabIndex = 4;
            this.txtNuevoPais.TextChanged += new System.EventHandler(this.txtNuevoPais_TextChanged);
            this.txtNuevoPais.Leave += new System.EventHandler(this.txtNuevoPais_Leave);
            // 
            // txtNuevaPass
            // 
            this.txtNuevaPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNuevaPass.Location = new System.Drawing.Point(70, 297);
            this.txtNuevaPass.Name = "txtNuevaPass";
            this.txtNuevaPass.Size = new System.Drawing.Size(189, 13);
            this.txtNuevaPass.TabIndex = 5;
            this.txtNuevaPass.Leave += new System.EventHandler(this.txtNuevaPass_Leave);
            // 
            // btnGuardarRegistro
            // 
            this.btnGuardarRegistro.BackColor = System.Drawing.Color.Indigo;
            this.btnGuardarRegistro.FlatAppearance.BorderSize = 0;
            this.btnGuardarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarRegistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardarRegistro.Location = new System.Drawing.Point(282, 366);
            this.btnGuardarRegistro.Name = "btnGuardarRegistro";
            this.btnGuardarRegistro.Size = new System.Drawing.Size(92, 23);
            this.btnGuardarRegistro.TabIndex = 6;
            this.btnGuardarRegistro.Text = "Guardar registro";
            this.btnGuardarRegistro.UseVisualStyleBackColor = false;
            this.btnGuardarRegistro.Click += new System.EventHandler(this.btnGuardarRegistro_Click);
            // 
            // cmbRo1
            // 
            this.cmbRo1.FormattingEnabled = true;
            this.cmbRo1.Items.AddRange(new object[] {
            "Administrador",
            "Superusuario",
            "Usuario",
            "Cliente",
            "Visitante"});
            this.cmbRo1.Location = new System.Drawing.Point(293, 159);
            this.cmbRo1.Name = "cmbRo1";
            this.cmbRo1.Size = new System.Drawing.Size(165, 21);
            this.cmbRo1.TabIndex = 7;
            this.cmbRo1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbRo1.Leave += new System.EventHandler(this.cmbRo1_Leave);
            // 
            // chkAlta
            // 
            this.chkAlta.AutoSize = true;
            this.chkAlta.BackColor = System.Drawing.Color.Transparent;
            this.chkAlta.Location = new System.Drawing.Point(293, 197);
            this.chkAlta.Name = "chkAlta";
            this.chkAlta.Size = new System.Drawing.Size(44, 17);
            this.chkAlta.TabIndex = 8;
            this.chkAlta.Text = "Alta";
            this.chkAlta.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Location = new System.Drawing.Point(389, 265);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Location = new System.Drawing.Point(389, 243);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4.Location = new System.Drawing.Point(389, 220);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // chkBuscar
            // 
            this.chkBuscar.AutoSize = true;
            this.chkBuscar.BackColor = System.Drawing.Color.Transparent;
            this.chkBuscar.Location = new System.Drawing.Point(389, 197);
            this.chkBuscar.Name = "chkBuscar";
            this.chkBuscar.Size = new System.Drawing.Size(59, 17);
            this.chkBuscar.TabIndex = 12;
            this.chkBuscar.Text = "Buscar";
            this.chkBuscar.UseVisualStyleBackColor = false;
            // 
            // chkLista
            // 
            this.chkLista.AutoSize = true;
            this.chkLista.BackColor = System.Drawing.Color.Transparent;
            this.chkLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chkLista.Location = new System.Drawing.Point(293, 266);
            this.chkLista.Name = "chkLista";
            this.chkLista.Size = new System.Drawing.Size(48, 17);
            this.chkLista.TabIndex = 13;
            this.chkLista.Text = "Lista";
            this.chkLista.UseVisualStyleBackColor = false;
            // 
            // chkModificar
            // 
            this.chkModificar.AutoSize = true;
            this.chkModificar.BackColor = System.Drawing.Color.Transparent;
            this.chkModificar.Location = new System.Drawing.Point(293, 243);
            this.chkModificar.Name = "chkModificar";
            this.chkModificar.Size = new System.Drawing.Size(69, 17);
            this.chkModificar.TabIndex = 14;
            this.chkModificar.Text = "Modificar";
            this.chkModificar.UseVisualStyleBackColor = false;
            // 
            // chkBaja
            // 
            this.chkBaja.AutoSize = true;
            this.chkBaja.BackColor = System.Drawing.Color.Transparent;
            this.chkBaja.Location = new System.Drawing.Point(293, 220);
            this.chkBaja.Name = "chkBaja";
            this.chkBaja.Size = new System.Drawing.Size(47, 17);
            this.chkBaja.TabIndex = 15;
            this.chkBaja.Text = "Baja";
            this.chkBaja.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(380, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cerrar registro";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyeto_Medicios_de_LLuvia.Properties.Resources._17f3d638_bd6c_4526_9936_b54a34ae7f76;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkBaja);
            this.Controls.Add(this.chkModificar);
            this.Controls.Add(this.chkLista);
            this.Controls.Add(this.chkBuscar);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.chkAlta);
            this.Controls.Add(this.cmbRo1);
            this.Controls.Add(this.btnGuardarRegistro);
            this.Controls.Add(this.txtNuevaPass);
            this.Controls.Add(this.txtNuevoPais);
            this.Controls.Add(this.txtNuevoUser);
            this.Name = "FormRegistro";
            this.Text = "FormRegistro";
            this.Load += new System.EventHandler(this.FormRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNuevoUser;
        private System.Windows.Forms.TextBox txtNuevoPais;
        private System.Windows.Forms.TextBox txtNuevaPass;
        private System.Windows.Forms.Button btnGuardarRegistro;
        private System.Windows.Forms.ComboBox cmbRo1;
        private System.Windows.Forms.CheckBox chkAlta;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox chkBuscar;
        private System.Windows.Forms.CheckBox chkLista;
        private System.Windows.Forms.CheckBox chkModificar;
        private System.Windows.Forms.CheckBox chkBaja;
        private System.Windows.Forms.Button button1;
    }
}