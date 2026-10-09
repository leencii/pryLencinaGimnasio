namespace pryLencinaGimnasio
{
    partial class frmInscripcion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalcular = new Button();
            grpDatosPersonales = new GroupBox();
            cboxEstudiante = new CheckBox();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            lblEdad = new Label();
            lblNombre = new Label();
            grpDatos = new TabControl();
            tbpDatos = new TabPage();
            tbpPlan = new TabPage();
            grpPlan = new GroupBox();
            lblMeses = new Label();
            lblTurno = new Label();
            lblPlan = new Label();
            cboxCasillero = new CheckBox();
            txtMeses = new TextBox();
            cboxTruno = new ComboBox();
            cboxPlan = new ComboBox();
            tbpPagos = new TabPage();
            grpFormaDePago = new GroupBox();
            lblCuotas = new Label();
            rbtTarjeta = new RadioButton();
            cboxCuotas = new ComboBox();
            rbtEfectivo = new RadioButton();
            btnLimpiar = new Button();
            lblEstudiante = new Label();
            grpDatosPersonales.SuspendLayout();
            grpDatos.SuspendLayout();
            tbpDatos.SuspendLayout();
            tbpPlan.SuspendLayout();
            grpPlan.SuspendLayout();
            tbpPagos.SuspendLayout();
            grpFormaDePago.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(245, 77);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // grpDatosPersonales
            // 
            grpDatosPersonales.Controls.Add(lblEstudiante);
            grpDatosPersonales.Controls.Add(cboxEstudiante);
            grpDatosPersonales.Controls.Add(txtEdad);
            grpDatosPersonales.Controls.Add(txtNombre);
            grpDatosPersonales.Controls.Add(lblEdad);
            grpDatosPersonales.Controls.Add(lblNombre);
            grpDatosPersonales.Location = new Point(6, 6);
            grpDatosPersonales.Name = "grpDatosPersonales";
            grpDatosPersonales.Size = new Size(350, 111);
            grpDatosPersonales.TabIndex = 1;
            grpDatosPersonales.TabStop = false;
            grpDatosPersonales.Text = "Datos Personales";
            grpDatosPersonales.Enter += groupBox1_Enter;
            // 
            // cboxEstudiante
            // 
            cboxEstudiante.AutoSize = true;
            cboxEstudiante.Location = new Point(76, 82);
            cboxEstudiante.Name = "cboxEstudiante";
            cboxEstudiante.Size = new Size(81, 19);
            cboxEstudiante.TabIndex = 5;
            cboxEstudiante.Text = "Estudiante";
            cboxEstudiante.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(76, 48);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(76, 19);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(6, 56);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 27);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(tbpDatos);
            grpDatos.Controls.Add(tbpPlan);
            grpDatos.Controls.Add(tbpPagos);
            grpDatos.Location = new Point(2, 12);
            grpDatos.Name = "grpDatos";
            grpDatos.SelectedIndex = 0;
            grpDatos.Size = new Size(370, 148);
            grpDatos.TabIndex = 0;
            // 
            // tbpDatos
            // 
            tbpDatos.Controls.Add(grpDatosPersonales);
            tbpDatos.Location = new Point(4, 24);
            tbpDatos.Name = "tbpDatos";
            tbpDatos.Padding = new Padding(3);
            tbpDatos.Size = new Size(362, 120);
            tbpDatos.TabIndex = 0;
            tbpDatos.Text = "Datos";
            tbpDatos.UseVisualStyleBackColor = true;
            // 
            // tbpPlan
            // 
            tbpPlan.Controls.Add(grpPlan);
            tbpPlan.Location = new Point(4, 24);
            tbpPlan.Name = "tbpPlan";
            tbpPlan.Padding = new Padding(3);
            tbpPlan.Size = new Size(362, 120);
            tbpPlan.TabIndex = 1;
            tbpPlan.Text = "Plan";
            tbpPlan.UseVisualStyleBackColor = true;
            // 
            // grpPlan
            // 
            grpPlan.Controls.Add(lblMeses);
            grpPlan.Controls.Add(lblTurno);
            grpPlan.Controls.Add(lblPlan);
            grpPlan.Controls.Add(cboxCasillero);
            grpPlan.Controls.Add(txtMeses);
            grpPlan.Controls.Add(cboxTruno);
            grpPlan.Controls.Add(cboxPlan);
            grpPlan.Location = new Point(6, 6);
            grpPlan.Name = "grpPlan";
            grpPlan.Size = new Size(350, 108);
            grpPlan.TabIndex = 2;
            grpPlan.TabStop = false;
            grpPlan.Text = "Plan";
            grpPlan.Enter += groupBox1_Enter_1;
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(-2, 85);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(40, 15);
            lblMeses.TabIndex = 11;
            lblMeses.Text = "Meses";
            lblMeses.Click += label5_Click;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(0, 56);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(38, 15);
            lblTurno.TabIndex = 10;
            lblTurno.Text = "Turno";
            lblTurno.Click += lblTurno_Click;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(8, 27);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(30, 15);
            lblPlan.TabIndex = 9;
            lblPlan.Text = "Plan";
            // 
            // cboxCasillero
            // 
            cboxCasillero.AutoSize = true;
            cboxCasillero.Location = new Point(152, 81);
            cboxCasillero.Name = "cboxCasillero";
            cboxCasillero.Size = new Size(145, 19);
            cboxCasillero.TabIndex = 8;
            cboxCasillero.Text = "Casillero ($ 3.000/mes)";
            cboxCasillero.UseVisualStyleBackColor = true;
            cboxCasillero.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(44, 77);
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(93, 23);
            txtMeses.TabIndex = 7;
            // 
            // cboxTruno
            // 
            cboxTruno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxTruno.FormattingEnabled = true;
            cboxTruno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboxTruno.Location = new Point(44, 48);
            cboxTruno.Name = "cboxTruno";
            cboxTruno.Size = new Size(109, 23);
            cboxTruno.TabIndex = 6;
            cboxTruno.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cboxPlan
            // 
            cboxPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxPlan.FormattingEnabled = true;
            cboxPlan.Items.AddRange(new object[] { "Musculacion", "Funcional", "Natacion" });
            cboxPlan.Location = new Point(44, 19);
            cboxPlan.Name = "cboxPlan";
            cboxPlan.Size = new Size(109, 23);
            cboxPlan.TabIndex = 5;
            // 
            // tbpPagos
            // 
            tbpPagos.Controls.Add(btnLimpiar);
            tbpPagos.Controls.Add(grpFormaDePago);
            tbpPagos.Controls.Add(btnCalcular);
            tbpPagos.Location = new Point(4, 24);
            tbpPagos.Name = "tbpPagos";
            tbpPagos.Padding = new Padding(3);
            tbpPagos.Size = new Size(362, 120);
            tbpPagos.TabIndex = 2;
            tbpPagos.Text = "Pagos";
            tbpPagos.UseVisualStyleBackColor = true;
            // 
            // grpFormaDePago
            // 
            grpFormaDePago.Controls.Add(lblCuotas);
            grpFormaDePago.Controls.Add(rbtTarjeta);
            grpFormaDePago.Controls.Add(cboxCuotas);
            grpFormaDePago.Controls.Add(rbtEfectivo);
            grpFormaDePago.Location = new Point(6, 6);
            grpFormaDePago.Name = "grpFormaDePago";
            grpFormaDePago.Size = new Size(198, 108);
            grpFormaDePago.TabIndex = 2;
            grpFormaDePago.TabStop = false;
            grpFormaDePago.Text = "Forma de Pago";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(6, 80);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(44, 15);
            lblCuotas.TabIndex = 5;
            lblCuotas.Text = "Cuotas";
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(6, 47);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(59, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            rbtTarjeta.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // cboxCuotas
            // 
            cboxCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxCuotas.FormattingEnabled = true;
            cboxCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cboxCuotas.Location = new Point(66, 72);
            cboxCuotas.Name = "cboxCuotas";
            cboxCuotas.Size = new Size(83, 23);
            cboxCuotas.TabIndex = 4;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Checked = true;
            rbtEfectivo.Location = new Point(6, 22);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(245, 24);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.Location = new Point(6, 83);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(65, 15);
            lblEstudiante.TabIndex = 6;
            lblEstudiante.Text = "Estudiante:";
            lblEstudiante.Click += lblEstudiante_Click;
            // 
            // frmInscripcion
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 198);
            Controls.Add(grpDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo — Inscripción.";
            grpDatosPersonales.ResumeLayout(false);
            grpDatosPersonales.PerformLayout();
            grpDatos.ResumeLayout(false);
            tbpDatos.ResumeLayout(false);
            tbpPlan.ResumeLayout(false);
            grpPlan.ResumeLayout(false);
            grpPlan.PerformLayout();
            tbpPagos.ResumeLayout(false);
            grpFormaDePago.ResumeLayout(false);
            grpFormaDePago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCalcular;
        private GroupBox grpDatosPersonales;
        private TabControl grpDatos;
        private TabPage tbpDatos;
        private TabPage tbpPlan;
        private TabPage tbpPagos;
        private GroupBox grpPlan;
        private GroupBox grpFormaDePago;
        private CheckBox cboxEstudiante;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private Label lblEdad;
        private Label lblNombre;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private Button btnLimpiar;
        private Label lblCuotas;
        private ComboBox cboxCuotas;
        private CheckBox cboxCasillero;
        private TextBox txtMeses;
        private ComboBox cboxTruno;
        private ComboBox cboxPlan;
        private Label lblMeses;
        private Label lblTurno;
        private Label lblPlan;
        private Label lblEstudiante;
    }
}
