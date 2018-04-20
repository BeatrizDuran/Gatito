using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JueguitoGatito
{
    public class Tablero
    {
        public int[,] gato = new int[3,3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        public bool turno = true;
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

        //Turno de los jugadores. 'X' siempre empieza.
        public void TurnoJugador()
        {
           if( turno == true)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("  Turno 1: Cruz");
                Console.Write(" Posición:");
                jugador.Cruz();
                jugador.Ganador();
                turno = false;
            }
            else{ 
                Console.WriteLine("-------------------------------");
                Console.WriteLine("  Turno 2: Círculo");
                Console.Write(" Posición:");
                jugador.Circulo();
                jugador.Ganador();
                turno = true;
            }
        }
    }
}
