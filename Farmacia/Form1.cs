using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            String medicamento = txtMedicamento.Text.Trim();
            String tipo = cmbTipo.SelectedItem?.ToString();
            String distribuidor = rdbCofarma.Checked ? "Cofarma" :
                                  rdbEmsephar.Checked ? "Emsephar" :
                                  rdbCemefar.Checked ? "Cemefar" : null;
            bool sucPrincipal = chkPrincipal.Checked;
            bool sucSecundaria = chkSecundaria.Checked;
            Console.WriteLine(medicamento);
            if (String.IsNullOrWhiteSpace(medicamento) || !Regex.IsMatch(medicamento, @"^[a-zA-Z0-9áéíóúÁÉÍÓÚñÑüÜ\\s]+$"))
            {
                MessageBox.Show("Escribe un nombre valido para el medicamento", "Error datos ingresados");
                return;
            }
            if (tipo == null)
            {
                MessageBox.Show("Por favor eliga un tipo de medicamento", "Error datos ingresados");
                return;
            }
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Escriba un número valido para la cantidad de medicamento", "Error datos ingresados");
                return;
            }
            if (distribuidor == null)
            {
                MessageBox.Show("Seleccione un distribuidor","Error datos ingresados");
                return;
            }
            if (!sucPrincipal && !sucSecundaria)
            {
                MessageBox.Show("Seleccione una sucursal", "Error datos ingresados");
                return;
            }
            var pedido = new Pedido
            {
                medicamento = medicamento,
                tipo = tipo,
                cantidad = cantidad,
                distribuidor = distribuidor,
                sucursalPrincipal = sucPrincipal,
                sucursalSecundaria = sucSecundaria
            };

            var resumen = new ResumenForm(pedido);
            resumen.ShowDialog();
            this.Close();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtMedicamento.Clear();
            cmbTipo.SelectedIndex = -1;
            txtCantidad.Clear();
            rdbCofarma.Checked = rdbCemefar.Checked = rdbEmsephar.Checked = false;
            chkPrincipal.Checked = chkSecundaria.Checked = false;
        }
    }
}
