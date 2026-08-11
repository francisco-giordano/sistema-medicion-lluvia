namespace Proyeto_Medicios_de_LLuvia
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.RegistrarMedicion = new System.Windows.Forms.TabControl();
            this.RegistrarMedicionn = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.txtAgua = new System.Windows.Forms.TextBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.tabPageconsultas = new System.Windows.Forms.TabPage();
            this.lstMostrarConsulta = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpHastaQueFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbELocalidad = new System.Windows.Forms.ComboBox();
            this.dtpDesdeQueFecha = new System.Windows.Forms.DateTimePicker();
            this.tabPageMax = new System.Windows.Forms.TabPage();
            this.btnOrdenarLLuvia = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMaximo = new System.Windows.Forms.Button();
            this.nudMaximo = new System.Windows.Forms.NumericUpDown();
            this.tabPageAlerta = new System.Windows.Forms.TabPage();
            this.dgvAlertas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlertas = new System.Windows.Forms.Button();
            this.tabPageListado = new System.Windows.Forms.TabPage();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dgvListaTotal = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrarMedicion.SuspendLayout();
            this.RegistrarMedicionn.SuspendLayout();
            this.tabPageconsultas.SuspendLayout();
            this.tabPageMax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximo)).BeginInit();
            this.tabPageAlerta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertas)).BeginInit();
            this.tabPageListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // RegistrarMedicion
            // 
            this.RegistrarMedicion.Controls.Add(this.RegistrarMedicionn);
            this.RegistrarMedicion.Controls.Add(this.tabPageconsultas);
            this.RegistrarMedicion.Controls.Add(this.tabPageMax);
            this.RegistrarMedicion.Controls.Add(this.tabPageAlerta);
            this.RegistrarMedicion.Controls.Add(this.tabPageListado);
            this.RegistrarMedicion.Location = new System.Drawing.Point(36, 12);
            this.RegistrarMedicion.Name = "RegistrarMedicion";
            this.RegistrarMedicion.SelectedIndex = 0;
            this.RegistrarMedicion.Size = new System.Drawing.Size(698, 394);
            this.RegistrarMedicion.TabIndex = 0;
            this.RegistrarMedicion.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.RegistrarMedicion_Selecting);
            // 
            // RegistrarMedicionn
            // 
            this.RegistrarMedicionn.Controls.Add(this.label4);
            this.RegistrarMedicionn.Controls.Add(this.label3);
            this.RegistrarMedicionn.Controls.Add(this.label2);
            this.RegistrarMedicionn.Controls.Add(this.label1);
            this.RegistrarMedicionn.Controls.Add(this.btnAgregar);
            this.RegistrarMedicionn.Controls.Add(this.txtResponsable);
            this.RegistrarMedicionn.Controls.Add(this.txtAgua);
            this.RegistrarMedicionn.Controls.Add(this.cmbLocalidad);
            this.RegistrarMedicionn.Controls.Add(this.dtpFecha);
            this.RegistrarMedicionn.Location = new System.Drawing.Point(4, 22);
            this.RegistrarMedicionn.Name = "RegistrarMedicionn";
            this.RegistrarMedicionn.Padding = new System.Windows.Forms.Padding(3);
            this.RegistrarMedicionn.Size = new System.Drawing.Size(690, 368);
            this.RegistrarMedicionn.TabIndex = 0;
            this.RegistrarMedicionn.Text = "Registrar Medicion";
            this.RegistrarMedicionn.UseVisualStyleBackColor = true;
            this.RegistrarMedicionn.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Especificar Fecha y Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Especificar Localidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad de Agua";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del Responsable";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(345, 128);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 51);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar Medicion";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(6, 243);
            this.txtResponsable.Multiline = true;
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(123, 21);
            this.txtResponsable.TabIndex = 3;
            // 
            // txtAgua
            // 
            this.txtAgua.Location = new System.Drawing.Point(9, 131);
            this.txtAgua.Multiline = true;
            this.txtAgua.Name = "txtAgua";
            this.txtAgua.Size = new System.Drawing.Size(89, 19);
            this.txtAgua.TabIndex = 2;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(345, 64);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(121, 21);
            this.cmbLocalidad.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(3, 64);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(228, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // tabPageconsultas
            // 
            this.tabPageconsultas.Controls.Add(this.lstMostrarConsulta);
            this.tabPageconsultas.Controls.Add(this.label7);
            this.tabPageconsultas.Controls.Add(this.dtpHastaQueFecha);
            this.tabPageconsultas.Controls.Add(this.btnCalcular);
            this.tabPageconsultas.Controls.Add(this.label5);
            this.tabPageconsultas.Controls.Add(this.label6);
            this.tabPageconsultas.Controls.Add(this.cmbELocalidad);
            this.tabPageconsultas.Controls.Add(this.dtpDesdeQueFecha);
            this.tabPageconsultas.Location = new System.Drawing.Point(4, 22);
            this.tabPageconsultas.Name = "tabPageconsultas";
            this.tabPageconsultas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageconsultas.Size = new System.Drawing.Size(690, 368);
            this.tabPageconsultas.TabIndex = 1;
            this.tabPageconsultas.Text = "Consultas";
            this.tabPageconsultas.UseVisualStyleBackColor = true;
            this.tabPageconsultas.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lstMostrarConsulta
            // 
            this.lstMostrarConsulta.FormattingEnabled = true;
            this.lstMostrarConsulta.Location = new System.Drawing.Point(431, 91);
            this.lstMostrarConsulta.Name = "lstMostrarConsulta";
            this.lstMostrarConsulta.Size = new System.Drawing.Size(256, 277);
            this.lstMostrarConsulta.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Especificar hasta\r\n que fecha";
            // 
            // dtpHastaQueFecha
            // 
            this.dtpHastaQueFecha.Location = new System.Drawing.Point(3, 115);
            this.dtpHastaQueFecha.Name = "dtpHastaQueFecha";
            this.dtpHastaQueFecha.Size = new System.Drawing.Size(228, 20);
            this.dtpHastaQueFecha.TabIndex = 14;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(6, 154);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(131, 23);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Especificar  desde que fecha";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(563, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Especificar Localidad";
            // 
            // cmbELocalidad
            // 
            this.cmbELocalidad.FormattingEnabled = true;
            this.cmbELocalidad.Location = new System.Drawing.Point(566, 45);
            this.cmbELocalidad.Name = "cmbELocalidad";
            this.cmbELocalidad.Size = new System.Drawing.Size(121, 21);
            this.cmbELocalidad.TabIndex = 10;
            // 
            // dtpDesdeQueFecha
            // 
            this.dtpDesdeQueFecha.Location = new System.Drawing.Point(6, 46);
            this.dtpDesdeQueFecha.Name = "dtpDesdeQueFecha";
            this.dtpDesdeQueFecha.Size = new System.Drawing.Size(228, 20);
            this.dtpDesdeQueFecha.TabIndex = 9;
            // 
            // tabPageMax
            // 
            this.tabPageMax.Controls.Add(this.btnOrdenarLLuvia);
            this.tabPageMax.Controls.Add(this.textBox1);
            this.tabPageMax.Controls.Add(this.label8);
            this.tabPageMax.Controls.Add(this.btnMaximo);
            this.tabPageMax.Controls.Add(this.nudMaximo);
            this.tabPageMax.Location = new System.Drawing.Point(4, 22);
            this.tabPageMax.Name = "tabPageMax";
            this.tabPageMax.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMax.Size = new System.Drawing.Size(690, 368);
            this.tabPageMax.TabIndex = 2;
            this.tabPageMax.Text = "Maximos";
            this.tabPageMax.UseVisualStyleBackColor = true;
            // 
            // btnOrdenarLLuvia
            // 
            this.btnOrdenarLLuvia.Location = new System.Drawing.Point(354, 35);
            this.btnOrdenarLLuvia.Name = "btnOrdenarLLuvia";
            this.btnOrdenarLLuvia.Size = new System.Drawing.Size(125, 49);
            this.btnOrdenarLLuvia.TabIndex = 4;
            this.btnOrdenarLLuvia.Text = "OrdenarLLuvia";
            this.btnOrdenarLLuvia.UseVisualStyleBackColor = true;
            this.btnOrdenarLLuvia.Click += new System.EventHandler(this.btnOrdenarLLuvia_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(485, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 207);
            this.textBox1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Resultado:";
            // 
            // btnMaximo
            // 
            this.btnMaximo.Location = new System.Drawing.Point(6, 166);
            this.btnMaximo.Name = "btnMaximo";
            this.btnMaximo.Size = new System.Drawing.Size(125, 49);
            this.btnMaximo.TabIndex = 1;
            this.btnMaximo.Text = "Buscar Maximo";
            this.btnMaximo.UseVisualStyleBackColor = true;
            this.btnMaximo.Click += new System.EventHandler(this.btnMaximo_Click);
            // 
            // nudMaximo
            // 
            this.nudMaximo.Location = new System.Drawing.Point(3, 36);
            this.nudMaximo.Name = "nudMaximo";
            this.nudMaximo.Size = new System.Drawing.Size(242, 20);
            this.nudMaximo.TabIndex = 0;
            // 
            // tabPageAlerta
            // 
            this.tabPageAlerta.Controls.Add(this.dgvAlertas);
            this.tabPageAlerta.Controls.Add(this.btnAlertas);
            this.tabPageAlerta.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlerta.Name = "tabPageAlerta";
            this.tabPageAlerta.Size = new System.Drawing.Size(690, 368);
            this.tabPageAlerta.TabIndex = 3;
            this.tabPageAlerta.Text = "Alertas";
            this.tabPageAlerta.UseVisualStyleBackColor = true;
            this.tabPageAlerta.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // dgvAlertas
            // 
            this.dgvAlertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlertas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Estado});
            this.dgvAlertas.Location = new System.Drawing.Point(0, 73);
            this.dgvAlertas.Name = "dgvAlertas";
            this.dgvAlertas.Size = new System.Drawing.Size(631, 278);
            this.dgvAlertas.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Localidad";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Hora";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad (mm)";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Diferencia";
            this.Column5.Name = "Column5";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // btnAlertas
            // 
            this.btnAlertas.Location = new System.Drawing.Point(0, 44);
            this.btnAlertas.Name = "btnAlertas";
            this.btnAlertas.Size = new System.Drawing.Size(120, 23);
            this.btnAlertas.TabIndex = 0;
            this.btnAlertas.Text = "Detectar Alerta";
            this.btnAlertas.UseVisualStyleBackColor = true;
            this.btnAlertas.Click += new System.EventHandler(this.btnAlertas_Click);
            // 
            // tabPageListado
            // 
            this.tabPageListado.Controls.Add(this.btnMostrar);
            this.tabPageListado.Controls.Add(this.dgvListaTotal);
            this.tabPageListado.Location = new System.Drawing.Point(4, 22);
            this.tabPageListado.Name = "tabPageListado";
            this.tabPageListado.Size = new System.Drawing.Size(690, 368);
            this.tabPageListado.TabIndex = 4;
            this.tabPageListado.Text = "Listado";
            this.tabPageListado.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(51, 87);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(120, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Resultados";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dgvListaTotal
            // 
            this.dgvListaTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvListaTotal.Location = new System.Drawing.Point(51, 116);
            this.dgvListaTotal.Name = "dgvListaTotal";
            this.dgvListaTotal.Size = new System.Drawing.Size(571, 216);
            this.dgvListaTotal.TabIndex = 0;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Localidad";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Fecha";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Hora";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Cantidad (mm)";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Responsable";
            this.Column10.Name = "Column10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegistrarMedicion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RegistrarMedicion.ResumeLayout(false);
            this.RegistrarMedicionn.ResumeLayout(false);
            this.RegistrarMedicionn.PerformLayout();
            this.tabPageconsultas.ResumeLayout(false);
            this.tabPageconsultas.PerformLayout();
            this.tabPageMax.ResumeLayout(false);
            this.tabPageMax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximo)).EndInit();
            this.tabPageAlerta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertas)).EndInit();
            this.tabPageListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl RegistrarMedicion;
        private System.Windows.Forms.TabPage RegistrarMedicionn;
        private System.Windows.Forms.TabPage tabPageconsultas;
        private System.Windows.Forms.TabPage tabPageMax;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.TextBox txtAgua;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageAlerta;
        private System.Windows.Forms.TabPage tabPageListado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbELocalidad;
        private System.Windows.Forms.DateTimePicker dtpDesdeQueFecha;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox lstMostrarConsulta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpHastaQueFecha;
        private System.Windows.Forms.NumericUpDown nudMaximo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMaximo;
        private System.Windows.Forms.DataGridView dgvAlertas;
        private System.Windows.Forms.Button btnAlertas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridView dgvListaTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnOrdenarLLuvia;
        private System.Windows.Forms.TextBox textBox1;
    }
}

