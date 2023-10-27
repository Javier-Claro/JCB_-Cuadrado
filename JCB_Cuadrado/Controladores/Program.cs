using JCB_Cuadrado.Servicios;

namespace Ejercicio2NumCuadrado.Controladores
{

    class Program
    {

        static void Main(string[] args)
        {
            PedirNumeroIntfz num = new PedirNumeroImpl();
            double numPedido, raiz;


            numPedido = num.pedirNumero();
            raiz = Math.Sqrt(numPedido);

            if (raiz * raiz == numPedido)
                Console.WriteLine("El numero es entero");
            else
                Console.WriteLine("El numero no es entero");

        }
    }
}