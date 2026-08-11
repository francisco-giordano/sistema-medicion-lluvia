namespace Proyeto_Medicios_de_LLuvia
{
    partial class FormLog
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
            this.btnIrARegistro = new System.Windows.Forms.Button();
            this.txtUserLogin = new System.Windows.Forms.TextBox();
            this.txtPassLogin = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnRecuClave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIrARegistro
            // 
            this.btnIrARegistro.BackColor = System.Drawing.Color.Indigo;
            this.btnIrARegistro.FlatAppearance.BorderSize = 0;
            this.btnIrARegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrARegistro.ForeColor = System.Drawing.Color.Transparent;
            this.btnIrARegistro.Location = new System.Drawing.Point(151, 333);
            this.btnIrARegistro.Name = "btnIrARegistro";
            this.btnIrARegistro.Size = new System.Drawing.Size(213, 37);
            this.btnIrARegistro.TabIndex = 0;
            this.btnIrARegistro.Text = "LOGIN";
            this.btnIrARegistro.UseVisualStyleBackColor = false;
            this.btnIrARegistro.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserLogin.Location = new System.Drawing.Point(180, 228);
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(164, 13);
            this.txtUserLogin.TabIndex = 3;
            this.txtUserLogin.TextChanged += new System.EventHandler(this.txtUserLogin_TextChanged);
            this.txtUserLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveAdmin_KeyPress);
            // 
            // txtPassLogin
            // 
            this.txtPassLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassLogin.Location = new System.Drawing.Point(180, 272);
            this.txtPassLogin.Name = "txtPassLogin";
            this.txtPassLogin.PasswordChar = '*';
            this.txtPassLogin.Size = new System.Drawing.Size(164, 13);
            this.txtPassLogin.TabIndex = 4;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Thistle;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Location = new System.Drawing.Point(140, 304);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(98, 23);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Solicitar Registro";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIrARegistro_Click_1);
            // 
            // btnRecuClave
            // 
            this.btnRecuClave.BackColor = System.Drawing.Color.Thistle;
            this.btnRecuClave.FlatAppearance.BorderSize = 0;
            this.btnRecuClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuClave.Location = new System.Drawing.Point(255, 304);
            this.btnRecuClave.Name = "btnRecuClave";
            this.btnRecuClave.Size = new System.Drawing.Size(109, 23);
            this.btnRecuClave.TabIndex = 6;
            this.btnRecuClave.Text = "Recuperar Clave";
            this.btnRecuClave.UseVisualStyleBackColor = false;
            this.btnRecuClave.Click += new System.EventHandler(this.btnRecuClave_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(164, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyeto_Medicios_de_LLuvia.Properties.Resources.log_in;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 504);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRecuClave);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtPassLogin);
            this.Controls.Add(this.txtUserLogin);
            this.Controls.Add(this.btnIrARegistro);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormLog";
            this.Text = "FormLog";
            this.Load += new System.EventHandler(this.FormLog_Load);
            this.Leave += new System.EventHandler(this.FormLog_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIrARegistro;
        private System.Windows.Forms.TextBox txtUserLogin;
        private System.Windows.Forms.TextBox txtPassLogin;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnRecuClave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}