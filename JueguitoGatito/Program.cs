using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JueguitoGatito
{
    class Program
    {
        static void Main(string[] args)
        {
            double p;
            bool op = true;
            Tablero tablero = new Tablero();
            Console.WriteLine("------------------ ");
            Console.WriteLine("     GATITO    ");
            Console.WriteLine("------------------ ");
            Console.WriteLine(" ");
            Console.WriteLine("Jugadores: ");
            Console.WriteLine("CRUZ = 11 ");
            Console.WriteLine("CIRCULO = 0 ");
            tablero.FormarTablero();
            do
            {
                tablero.TurnoJugador();
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            } while (op == true);
           
            Console.ReadKey();
        }
    }
}
