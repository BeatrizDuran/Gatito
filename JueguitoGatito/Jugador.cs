using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JueguitoGatito
{
    public class Jugador
    {
        int[,] arr;
        int ren;
        int col;

        //Metodo el cual se utiliza para escribir la posición del círculo 'O'.
        public void Circulo()
        {
           
        }
        //Método el cual se utiliza para escribir la posición de la  ' X '.
        public void Cruz()
        {

            for (int f = 0; f < ren; f++)
            {
                for (int c = 0; c < col; c++)
                {
                    arr = new int[ren, col];
                    string linea;
                    linea = Console.ReadLine();
                    arr[ren, col] = int.Parse(linea); 
                }
            }
        }

        //Método el cual imprime el resultado de la letra ingresada.
        public void Imprimir()
        {
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(arr[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    
}
