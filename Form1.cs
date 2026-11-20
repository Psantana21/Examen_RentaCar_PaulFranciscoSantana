
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examen_RentaCar_PaulFranciscoSantana
{
    public partial class Form1 : Form
    {
        decimal subtotal = 0m;

        public Form1()
        {
            InitializeComponent();

            lblEncabezado.Font = new Font("Consolas", 9);
            lstAlquileres.Font = new Font("Consolas", 9);

            lblEncabezado.Text =
                "Días".PadRight(6) +
                "Vehículo".PadRight(24) +
                "Tarifa".PadLeft(10) +
                "Total".PadLeft(12);

            dtpSalida.Value = DateTime.Today;

            nudDias.Minimum = 1;
            nudDias.Maximum = 30;
            rbtBasico.Checked = true;
            rbtSucursal.Checked = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text) ||
                string.IsNullOrWhiteSpace(txtVehiculo.Text) ||
                !decimal.TryParse(txtTarifa.Text, out decimal tarifa) ||
                tarifa <= 0)
            {
                MessageBox.Show("Complete los datos correctamente.");
                return;
            }

            decimal tarifaDiaria = tarifa;
            decimal dias = nudDias.Value;

            if (rbtCompleto.Checked)
                tarifaDiaria += 300m;

            if (chkGps.Checked)
                tarifaDiaria += 100m;

            decimal totalLinea = tarifaDiaria * dias;

            subtotal += totalLinea;

            string vehiculo = txtVehiculo.Text.Trim();
            string seguro = rbtCompleto.Checked ? "Completo" : "Básico";

            string descripcion = vehiculo + " (" + seguro + ")";

            string linea =
                dias.ToString().PadRight(6) +
                descripcion.PadRight(24) +
                tarifaDiaria.ToString("N2").PadLeft(10) +
                totalLinea.ToString("N2").PadLeft(12);

            lstAlquileres.Items.Add(linea);
            MessageBox.Show("Alquiler agregado correctamente.");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal descuento = chkCorporativo.Checked
                ? subtotal * 0.15m : 0m;

            decimal domicilio = rbtDomicilio.Checked
                ? 500m : 0m;

            decimal baseImponible = subtotal - descuento + domicilio;
            decimal itbis = baseImponible * 0.18m;
            decimal total = baseImponible + itbis;

            lblSubtotal.Text = $"RD$ {subtotal:N2}";
            lblDescuento.Text = $"RD$ {descuento:N2}";
            lblDomicilio.Text = $"RD$ {domicilio:N2}";
            lblitbis.Text = $"RD$ {itbis:N2}";
            lblTotal.Text = $"RD$ {total:N2}";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtVehiculo.Clear();
            txtTarifa.Clear();

            nudDias.Value = 1;

            chkCorporativo.Checked = false;
            chkGps.Checked = false;

            rbtBasico.Checked = true;
            rbtSucursal.Checked = true;

            lstAlquileres.Items.Clear();

            lblSubtotal.Text = "0.00";
            lblDescuento.Text = "0.00";
            lblDomicilio.Text = "0.00";
            lblitbis.Text = "0.00";
            lblTotal.Text = "0.00";

            subtotal = 0m;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir de la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void lblDescuento_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
    }
}
