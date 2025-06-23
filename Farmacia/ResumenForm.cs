using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class ResumenForm : Form
    {
        private Pedido _pedido;
        public ResumenForm(Pedido pedido)
        {
            InitializeComponent();
            _pedido = pedido;
            lblTitulo.Text = $"Pedido al distribuidor {_pedido.distribuidor}";
            lblMedicamento.Text = _pedido.ObtenerResumen();
            lblDireccion.Text = $"Para la farmacia situada en {_pedido.ObtenerDireccion()}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido enviado","Pedido");
            this.Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
