using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCB_Cuadrado.Servicios
{
     internal class PedirNumeroImpl : PedirNumeroIntfz
    {

        public double pedirNumero()
        {
            double numeroPedido;
            Console.WriteLine("Escriba un nuemro entero ");
            numeroPedido = Convert.ToDouble(Console.ReadLine());

            return numeroPedido;
        }
    }
}
