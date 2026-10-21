using System;
using System.Windows.Forms;

namespace pryLencinaGimnasio
{
    public partial class frmInscripcion : Form
    {
        // declarar el array
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

        // declaramos la variable del struct arriba
        SOCIO sOCIO;

        #region declaracion de constante
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cboxCuotas.Enabled = rbtTarjeta.Checked;
            if (!rbtTarjeta.Checked)
                cboxCuotas.SelectedIndex = -1;
            else if (cboxCuotas.Items.Count > 0)
                cboxCuotas.SelectedIndex = 0;
        }

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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            sOCIO.nombre = txtNombre.Text;
            sOCIO.edad = int.Parse(txtEdad.Text);
            sOCIO.meses = int.Parse(txtMeses.Text);

            // switch 
            sOCIO.precioMensual = cboxPlan.SelectedIndex switch
            {
                0 => PRECIO_MUSCULACION,
                1 => PRECIO_FUNCIONAL,
                2 => PRECIO_NATACION,
                _ => 0m
            };

            sOCIO.subtotal = sOCIO.precioMensual * sOCIO.meses;

            #region calculo de precio mensual segun plan
            if (cboxCasillero.Checked)
            {
                sOCIO.subtotal += PRECIO_CASILLERO * sOCIO.meses;
            }
            sOCIO.total = sOCIO.subtotal;
            #endregion

            #region validacion edad y mes
            if (sOCIO.edad < EDAD_MINIMA)
            {
                MessageBox.Show($"El cliente {sOCIO.nombre} no cumple con la edad mínima de {EDAD_MINIMA} años para inscribirse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EstadoInicial();
                return;
            }
            if (sOCIO.meses < 1 || sOCIO.meses > 12)
            {
                MessageBox.Show($"El cliente {sOCIO.nombre} no puede inscribirse por esa cantidad de meses.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EstadoInicial();
                return;
            }
            #endregion

            #region turno seleccionado
            // el switch de los turnos 
            string horarioSeleccionado = cboxTruno.Text;
            switch (horarioSeleccionado)
            {
                case "Mañana":
                    horarioSeleccionado = "Mañana";
                    break;
                case "Tarde":
                    horarioSeleccionado = "Tarde";
                    break;
                case "Noche":
                    horarioSeleccionado = "Noche";
                    break;
            }
            #endregion

            #region descuento por edad y estudiante
            // uso de if/else para los descuentos
            sOCIO.total = sOCIO.subtotal;
            if (sOCIO.edad < 18)
            {
                sOCIO.porcentajeDescuento = sOCIO.subtotal * 0.25m;
                sOCIO.total -= sOCIO.porcentajeDescuento;
            }
            else
            {
                if (sOCIO.edad >= 65)
                {
                    sOCIO.porcentajeDescuento = sOCIO.subtotal * 0.30m;
                    sOCIO.total -= sOCIO.porcentajeDescuento;
                }
                else
                {
                    if (cboxEstudiante.Checked)
                    {
                        sOCIO.porcentajeDescuento = sOCIO.subtotal * 0.15m;
                        sOCIO.total -= sOCIO.porcentajeDescuento;
                    }
                    else
                    {
                        sOCIO.porcentajeDescuento = 0;
                    }
                }
            }
            #endregion

            #region forma de pago y recargos
            if (rbtEfectivo.Checked)
            {
                sOCIO.porcentajeAjuste = -(sOCIO.total * 0.10m);
                sOCIO.total += sOCIO.porcentajeAjuste;
            }
            else if (rbtTarjeta.Checked && cboxCuotas.SelectedIndex != -1)
            {
                if (cboxCuotas.Text == "3") sOCIO.porcentajeAjuste = sOCIO.total * 0.10m;
                else if (cboxCuotas.Text == "6") sOCIO.porcentajeAjuste = sOCIO.total * 0.20m;
                else sOCIO.porcentajeAjuste = 0;

                sOCIO.total += sOCIO.porcentajeAjuste;

                int cuotas = int.Parse(cboxCuotas.Text);
                sOCIO.valorCuota = sOCIO.total / cuotas;
            }
            #endregion

            MessageBox.Show($"Resumen de inscripcion\n" +
                    $"Cliente: {sOCIO.nombre}\n" +
                    $"Edad: {sOCIO.edad}\n" +
                    $"Meses: {sOCIO.meses}\n" +
                    $"Subtotal: ${sOCIO.subtotal:0}\n" +
                    $"Descuento aplicado: ${sOCIO.porcentajeDescuento:0}\n" +
                    $"Total a pagar: ${sOCIO.total:0}",
                    "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // guardar en el array manteniendo el límite de 3
            if (indiceClientes < 3)
            {
                arrayClientes[indiceClientes] = sOCIO;
                indiceClientes++;
            }
            else
            {
                MessageBox.Show("Se ha alcanzado el límite de 3 clientes.");
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
    }
}