using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JueguitoGatito
{
    public class Tablero
    {
        public int[,] gato = new int[3,3];
        public bool turnoX = true;
        Jugador jugador = new Jugador();
       public void FormarTablero()
        {
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write("   "+gato[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        public void turno()
        {
           if( turnoX == true)
            {
                Console.WriteLine("  Turno 1: Cruz");
                Console.WriteLine(" Posición:");
                jugador.Cruz();
                jugador.Imprimir();
                turnoX = false;
            }
            if (turnoX == false)
            {
                Console.WriteLine("  Turno 2: Círculo");
                Console.WriteLine(" Posición:");
                jugador.Circulo();
                turnoX = true;
            }
        }
    }
}
