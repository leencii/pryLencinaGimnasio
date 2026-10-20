using System;
using System.Windows.Forms;

namespace pryLencinaGimnasio
{
    public partial class frmInscripcion : Form
    {
        // declarar el array para máximo 3 clientes
        SOCIO[] arrayClientes = new SOCIO[3];
        int indiceClientes = 0;

        public struct SOCIO
        {
            public string nombre;
            public int edad;
            public int meses;
            public decimal precioMensual;
            public decimal subtotal;
            public decimal porcentajeDescuento;
            public decimal porcentajeAjuste;
            public decimal total;
            public decimal valorCuota;
        }

        #region Declaracion de constantes
        public const decimal PRECIO_MUSCULACION = 15000m;
        public const decimal PRECIO_FUNCIONAL = 18000m;
        public const decimal PRECIO_NATACION = 22000m;
        public const decimal PRECIO_CASILLERO = 3000m;
        public const int EDAD_MINIMA = 14;
        #endregion

        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            EstadoInicial();
            ActivarBotonCalcularFormulario();
        }

        private void ActivarBotonCalcularFormulario()
        {
            if (txtNombre.Text != "" && txtEdad.Text != "" && txtMeses.Text != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void EstadoInicial()
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtMeses.Text = "1";

            cboxCasillero.Checked = false;
            cboxEstudiante.Checked = false;
            cboxPlan.SelectedIndex = 0;
            cboxTruno.SelectedIndex = 0;
            rbtEfectivo.Checked = true;
            cboxCuotas.SelectedIndex = -1;
            cboxCuotas.Enabled = false;

            btnCalcular.Enabled = false;
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        // validaciones del teclado
        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e) => ActivarBotonCalcularFormulario();
        private void txtEdad_TextChanged(object sender, EventArgs e) => ActivarBotonCalcularFormulario();
        private void txtMeses_TextChanged(object sender, EventArgs e) => ActivarBotonCalcularFormulario();

        // logica
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            SOCIO sOCIO = new SOCIO();

            sOCIO.nombre = txtNombre.Text;
            sOCIO.edad = int.Parse(txtEdad.Text);
            sOCIO.meses = int.Parse(txtMeses.Text);

            #region Validacion edad y mes
            if (sOCIO.edad < EDAD_MINIMA)
            {
                MessageBox.Show($"El cliente no cumple con la edad mínima de {EDAD_MINIMA} años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sOCIO.meses < 1 || sOCIO.meses > 12)
            {
                MessageBox.Show("La cantidad de meses debe estar entre 1 y 12.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region Calculo de precio mensual segun plan
            sOCIO.precioMensual = cboxPlan.Text switch
            {
                "Musculación" => PRECIO_MUSCULACION,
                "Musculacion" => PRECIO_MUSCULACION,
                "Funcional" => PRECIO_FUNCIONAL,
                "Natación" => PRECIO_NATACION,
                "Natacion" => PRECIO_NATACION,
                _ => PRECIO_MUSCULACION
            };

            if (cboxCasillero.Checked)
            {
                sOCIO.precioMensual += PRECIO_CASILLERO;
            }

            sOCIO.subtotal = sOCIO.precioMensual * sOCIO.meses;
            sOCIO.total = sOCIO.subtotal;
            #endregion

            #region Descuento por edad y estudiante
            if (sOCIO.edad < 18)
            {
                sOCIO.porcentajeDescuento = sOCIO.subtotal * 0.25m;
            }
            else if (sOCIO.edad >= 65)
            {
                sOCIO.porcentajeDescuento = sOCIO.subtotal * 0.30m;
            }
            else if (cboxEstudiante.Checked)
            {
                sOCIO.porcentajeDescuento = sOCIO.subtotal * 0.15m;
            }
            else
            {
                sOCIO.porcentajeDescuento = 0;
            }

            sOCIO.total -= sOCIO.porcentajeDescuento;
            #endregion

            #region Modificador por forma de pago
            if (rbtEfectivo.Checked)
            {
                sOCIO.porcentajeAjuste = -(sOCIO.total * 0.10m);
            }
            else if (rbtTarjeta.Checked && cboxCuotas.SelectedIndex != -1)
            {
                string cuotas = cboxCuotas.Text;
                if (cuotas == "3") sOCIO.porcentajeAjuste = sOCIO.total * 0.10m;
                else if (cuotas == "6") sOCIO.porcentajeAjuste = sOCIO.total * 0.20m;
                else sOCIO.porcentajeAjuste = 0;
            }

            sOCIO.total += sOCIO.porcentajeAjuste;

            if (rbtTarjeta.Checked && cboxCuotas.SelectedIndex != -1)
            {
                int cantCuotas = int.Parse(cboxCuotas.Text);
                sOCIO.valorCuota = sOCIO.total / cantCuotas;
            }
            #endregion

            MessageBox.Show($"Resumen de inscripcion\n" +
                    $"Cliente: {sOCIO.nombre}\n" +
                    $"Meses: {sOCIO.meses}\n" +
                    $"Subtotal: ${sOCIO.subtotal:N2}\n" +
                    $"Total a pagar: ${sOCIO.total:N2}",
                    "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // guardar en el array
            if (indiceClientes < 3)
            {
                arrayClientes[indiceClientes] = sOCIO;
                indiceClientes++;
            }
            else
            {
                MessageBox.Show("Se ha alcanzado el límite máximo de 3 clientes.", "Límite", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            EstadoInicial();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ltsConsulta.Items.Clear();

            if (indiceClientes == 0)
            {
                ltsConsulta.Items.Add("No hay clientes registrados aún.");
                return;
            }

            // Recorre hasta un máximo de 3 clientes 
            for (int i = 0; i < indiceClientes; i++)
            {
                SOCIO socioActual = arrayClientes[i];

                string formatoLinea = $"Cliente: {socioActual.nombre}, Edad: {socioActual.edad}, Meses: {socioActual.meses}, Subtotal: ${socioActual.subtotal:0}, Descuento aplicado: ${socioActual.porcentajeDescuento:0.00}, Total a pagar: ${socioActual.total:0.00}";

                ltsConsulta.Items.Add(formatoLinea);
                ltsConsulta.Items.Add("");
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void lblEstudiante_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter_1(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void lblTurno_Click(object sender, EventArgs e) { }
        private void checkBox2_CheckedChanged(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cboxCuotas.Enabled = rbtTarjeta.Checked;
            if (rbtTarjeta.Checked && cboxCuotas.Items.Count > 0)
            {
                cboxCuotas.SelectedIndex = 0;
            }
            else
            {
                cboxCuotas.SelectedIndex = -1;
            }
        }
    }
}