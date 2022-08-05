using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsitemas
{
    class CFachada
    {
        // Estos son los subsistemas que se estan utilizando 
        private CSistemaCompra compra = new CSistemaCompra();
        private CSubistemaAlmacen almacen = new CSubistemaAlmacen();
        private CSubsitemaEnvio envio = new CSubsitemaEnvio();

        //Este metodo es usada para realizar de forma sencilla una operacion 
        // mas compleja que requiere de uno o varios subsitemas 

        public void Compra()
        {
            if (compra.Comprar())
            {
                if (almacen.SacarAlmacen())
                {
                    envio.EnviarPedido();
                }
            }
        }
    }
}
