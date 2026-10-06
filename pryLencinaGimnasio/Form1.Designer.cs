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
            tabControl1 = new TabControl();
            tbpDatos = new TabPage();
            tbpPlan = new TabPage();
            tbpPagos = new TabPage();
            grpPlan = new GroupBox();
            grpFormaDePago = new GroupBox();
            lblNombre = new Label();
            lblEdad = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            cboxEstudiante = new CheckBox();
            rbtEfectivo = new RadioButton();
            rbtTarjeta = new RadioButton();
            btnLimpiar = new Button();
            comboBox1 = new ComboBox();
            lblCuotas = new Label();
            v = new ComboBox();
            comboBox2 = new ComboBox();
            textBox3 = new TextBox();
            cboxCasillero = new CheckBox();
            lblPlan = new Label();
            lblTurno = new Label();
            lblMeses = new Label();
            grpDatosPersonales.SuspendLayout();
            tabControl1.SuspendLayout();
            tbpDatos.SuspendLayout();
            tbpPlan.SuspendLayout();
            tbpPagos.SuspendLayout();
            grpPlan.SuspendLayout();
            grpFormaDePago.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(183, 199);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // grpDatosPersonales
            // 
            grpDatosPersonales.Controls.Add(cboxEstudiante);
            grpDatosPersonales.Controls.Add(textBox2);
            grpDatosPersonales.Controls.Add(textBox1);
            grpDatosPersonales.Controls.Add(lblEdad);
            grpDatosPersonales.Controls.Add(lblNombre);
            grpDatosPersonales.Location = new Point(6, 6);
            grpDatosPersonales.Name = "grpDatosPersonales";
            grpDatosPersonales.Size = new Size(230, 138);
            grpDatosPersonales.TabIndex = 1;
            grpDatosPersonales.TabStop = false;
            grpDatosPersonales.Text = "Datos Personales";
            grpDatosPersonales.Enter += groupBox1_Enter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpDatos);
            tabControl1.Controls.Add(tbpPlan);
            tabControl1.Controls.Add(tbpPagos);
            tabControl1.Location = new Point(2, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(260, 178);
            tabControl1.TabIndex = 0;
            // 
            // tbpDatos
            // 
            tbpDatos.Controls.Add(grpDatosPersonales);
            tbpDatos.Location = new Point(4, 24);
            tbpDatos.Name = "tbpDatos";
            tbpDatos.Padding = new Padding(3);
            tbpDatos.Size = new Size(252, 150);
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
            tbpPlan.Size = new Size(252, 150);
            tbpPlan.TabIndex = 1;
            tbpPlan.Text = "Plan";
            tbpPlan.UseVisualStyleBackColor = true;
            // 
            // tbpPagos
            // 
            tbpPagos.Controls.Add(grpFormaDePago);
            tbpPagos.Location = new Point(4, 24);
            tbpPagos.Name = "tbpPagos";
            tbpPagos.Padding = new Padding(3);
            tbpPagos.Size = new Size(252, 150);
            tbpPagos.TabIndex = 2;
            tbpPagos.Text = "Pagos";
            tbpPagos.UseVisualStyleBackColor = true;
            // 
            // grpPlan
            // 
            grpPlan.Controls.Add(lblMeses);
            grpPlan.Controls.Add(lblTurno);
            grpPlan.Controls.Add(lblPlan);
            grpPlan.Controls.Add(cboxCasillero);
            grpPlan.Controls.Add(textBox3);
            grpPlan.Controls.Add(comboBox2);
            grpPlan.Controls.Add(v);
            grpPlan.Location = new Point(6, 6);
            grpPlan.Name = "grpPlan";
            grpPlan.Size = new Size(230, 138);
            grpPlan.TabIndex = 2;
            grpPlan.TabStop = false;
            grpPlan.Text = "Plan";
            grpPlan.Enter += groupBox1_Enter_1;
            // 
            // grpFormaDePago
            // 
            grpFormaDePago.Controls.Add(lblCuotas);
            grpFormaDePago.Controls.Add(rbtTarjeta);
            grpFormaDePago.Controls.Add(comboBox1);
            grpFormaDePago.Controls.Add(rbtEfectivo);
            grpFormaDePago.Location = new Point(6, 6);
            grpFormaDePago.Name = "grpFormaDePago";
            grpFormaDePago.Size = new Size(233, 138);
            grpFormaDePago.TabIndex = 2;
            grpFormaDePago.TabStop = false;
            grpFormaDePago.Text = "Forma de Pago";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(18, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(18, 74);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(84, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // cboxEstudiante
            // 
            cboxEstudiante.AutoSize = true;
            cboxEstudiante.Location = new Point(18, 113);
            cboxEstudiante.Name = "cboxEstudiante";
            cboxEstudiante.Size = new Size(81, 19);
            cboxEstudiante.TabIndex = 5;
            cboxEstudiante.Text = "Estudiante";
            cboxEstudiante.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(18, 39);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(120, 39);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(60, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            rbtTarjeta.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(102, 199);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(90, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(83, 23);
            comboBox1.TabIndex = 4;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(18, 101);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(44, 15);
            lblCuotas.TabIndex = 5;
            lblCuotas.Text = "Cuotas";
            // 
            // v
            // 
            v.FormattingEnabled = true;
            v.Location = new Point(45, 27);
            v.Name = "v";
            v.Size = new Size(67, 23);
            v.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(45, 81);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(67, 23);
            comboBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(171, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(45, 23);
            textBox3.TabIndex = 7;
            // 
            // cboxCasillero
            // 
            cboxCasillero.AutoSize = true;
            cboxCasillero.Location = new Point(45, 113);
            cboxCasillero.Name = "cboxCasillero";
            cboxCasillero.Size = new Size(145, 19);
            cboxCasillero.TabIndex = 8;
            cboxCasillero.Text = "Casillero ($ 3.000/mes)";
            cboxCasillero.UseVisualStyleBackColor = true;
            cboxCasillero.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(-3, 35);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(30, 15);
            lblPlan.TabIndex = 9;
            lblPlan.Text = "Plan";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(0, 89);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(39, 15);
            lblTurno.TabIndex = 10;
            lblTurno.Text = "Turno";
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(125, 58);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(40, 15);
            lblMeses.TabIndex = 11;
            lblMeses.Text = "Meses";
            lblMeses.Click += label5_Click;
            // 
            // frmInscripcion
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 234);
            Controls.Add(btnLimpiar);
            Controls.Add(tabControl1);
            Controls.Add(btnCalcular);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo — Inscripción.";
            grpDatosPersonales.ResumeLayout(false);
            grpDatosPersonales.PerformLayout();
            tabControl1.ResumeLayout(false);
            tbpDatos.ResumeLayout(false);
            tbpPlan.ResumeLayout(false);
            tbpPagos.ResumeLayout(false);
            grpPlan.ResumeLayout(false);
            grpPlan.PerformLayout();
            grpFormaDePago.ResumeLayout(false);
            grpFormaDePago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCalcular;
        private GroupBox grpDatosPersonales;
        private TabControl tabControl1;
        private TabPage tbpDatos;
        private TabPage tbpPlan;
        private TabPage tbpPagos;
        private GroupBox grpPlan;
        private GroupBox grpFormaDePago;
        private CheckBox cboxEstudiante;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblEdad;
        private Label lblNombre;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private Button btnLimpiar;
        private Label lblCuotas;
        private ComboBox comboBox1;
        private CheckBox cboxCasillero;
        private TextBox textBox3;
        private ComboBox comboBox2;
        private ComboBox v;
        private Label lblMeses;
        private Label lblTurno;
        private Label lblPlan;
    }
}
