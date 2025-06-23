using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia
{
    public class Pedido
    {
        public String medicamento { get; set; }
        public String tipo { get; set; }
        public int cantidad { get; set; }
        public string distribuidor { get; set; }
        public bool sucursalPrincipal { get; set; }
        public bool sucursalSecundaria { get; set; }

        public String ObtenerDireccion()
        {
            string sucursales = "";
            if (sucursalPrincipal) sucursales += "Calle de la Rosa n. 28";
            if (sucursalPrincipal && sucursalSecundaria) sucursales += " y ";
            if (sucursalSecundaria) sucursales += "Calle Alcazabilla n. 3";
            return sucursales;
        }

        public String ObtenerResumen()
        {
            return $"{cantidad} unidades del {tipo} {medicamento}";
        }
    }
}
