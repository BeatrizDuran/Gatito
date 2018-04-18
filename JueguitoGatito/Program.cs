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
            Tablero tablero = new Tablero();
            Console.WriteLine("------------------ ");
            Console.WriteLine("     GATITO    ");
            Console.WriteLine("------------------ ");
            Console.WriteLine(" ");
            tablero.turno();
            Console.WriteLine(" ");
            tablero.FormarTablero();
            Console.WriteLine(" ");
           // p = double.Parse(Console.ReadLine());
            //tablero.arr1[p] =int.Parse(Console.ReadLine());
      
           // tablero.arr1[p]= int.Parse(Console.ReadLine());
           //if( tablero.arr1[p] == 0)
           // {
           //     tablero.Celda1();
           // }

          
            
            Console.ReadKey();
           
        }
    }
}
