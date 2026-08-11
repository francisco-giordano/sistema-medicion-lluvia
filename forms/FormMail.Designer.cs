namespace Proyeto_Medicios_de_LLuvia
{
    partial class FormMail
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
            this.btn_enviar_mail = new System.Windows.Forms.Button();
            this.txtNombreMail = new System.Windows.Forms.TextBox();
            this.txtDescripMail = new System.Windows.Forms.TextBox();
            this.txtDniMail = new System.Windows.Forms.TextBox();
            this.txtApellidoMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_enviar_mail
            // 
            this.btn_enviar_mail.Location = new System.Drawing.Point(354, 313);
            this.btn_enviar_mail.Name = "btn_enviar_mail";
            this.btn_enviar_mail.Size = new System.Drawing.Size(75, 23);
            this.btn_enviar_mail.TabIndex = 0;
            this.btn_enviar_mail.Text = "Enviar mail\r\n";
            this.btn_enviar_mail.UseVisualStyleBackColor = true;
            this.btn_enviar_mail.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombreMail
            // 
            this.txtNombreMail.Location = new System.Drawing.Point(171, 151);
            this.txtNombreMail.Name = "txtNombreMail";
            this.txtNombreMail.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMail.TabIndex = 1;
            // 
            // txtDescripMail
            // 
            this.txtDescripMail.Location = new System.Drawing.Point(258, 221);
            this.txtDescripMail.Name = "txtDescripMail";
            this.txtDescripMail.Size = new System.Drawing.Size(262, 20);
            this.txtDescripMail.TabIndex = 2;
            // 
            // txtDniMail
            // 
            this.txtDniMail.Location = new System.Drawing.Point(526, 151);
            this.txtDniMail.Name = "txtDniMail";
            this.txtDniMail.Size = new System.Drawing.Size(100, 20);
            this.txtDniMail.TabIndex = 3;
            // 
            // txtApellidoMail
            // 
            this.txtApellidoMail.Location = new System.Drawing.Point(343, 151);
            this.txtApellidoMail.Name = "txtApellidoMail";
            this.txtApellidoMail.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoMail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enviar Solicitud\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dni\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descripcion";
            // 
            // FormMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellidoMail);
            this.Controls.Add(this.txtDniMail);
            this.Controls.Add(this.txtDescripMail);
            this.Controls.Add(this.txtNombreMail);
            this.Controls.Add(this.btn_enviar_mail);
            this.Name = "FormMail";
            this.Text = "FormMail";
            this.Load += new System.EventHandler(this.FormMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enviar_mail;
        private System.Windows.Forms.TextBox txtNombreMail;
        private System.Windows.Forms.TextBox txtDescripMail;
        private System.Windows.Forms.TextBox txtDniMail;
        private System.Windows.Forms.TextBox txtApellidoMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}