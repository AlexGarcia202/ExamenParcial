using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CL_GestionPedidos
    {

        public double MtdPrecio(string MenuProductos)
        {
            if (MenuProductos == "1-Personal") return 100;
            else if (MenuProductos == "2-Mediano") return 200;
            else if (MenuProductos == "3-Familiar") return 300;
            
            else return 0;
        }


        public double MtdPrecioTotal(double Precio, double Cantidad)
        {
            return (Precio * Cantidad);
        }


        public double MtdPropina(string MenuProductos, double PrecioTotal)
        {
            if (MenuProductos == "1-Personal") return (PrecioTotal*0.08);
            else if (MenuProductos == "2-Mediano") return (PrecioTotal * 0.12);
            else if (MenuProductos == "3-Familiar") return (PrecioTotal * 0.16);

            else return 0;
        }

        public double MtdTotalPedido(double PrecioTotal, double Propina)
        {
            return (PrecioTotal + Propina);
        }



    }
}
