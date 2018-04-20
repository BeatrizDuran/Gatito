using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JueguitoGatito
{
    public class Jugador
    {
        int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 } , { 7, 8, 9 } };
        int linea;
        int valorX = 11;
        int valorO = 00;
        //Metodo el cual se utiliza para escribir la posición del círculo 'O'.
        public void Circulo()
        {
            linea = int.Parse(Console.ReadLine());
            if (linea == 1)
            {
                if (arr[0, 0] == valorX)
                {
                    Console.WriteLine("Ocupado por X");
                }
                else
                {
                    arr[0, 0] = valorO;
                    for (int f = 0; f < 3; f++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            Console.Write("   " + arr[f, c] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else if (linea == 2)
            {
                if (arr[0, 1] == valorX)
                {
                    Console.WriteLine("Ocupado por X");
                }
                else
                {
                    arr[0, 1] = valorO;
                    for (int f = 0; f < 3; f++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            Console.Write("   " + arr[f, c] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else if (linea == 3)
            {
                if (arr[0, 2] == valorX)
                {
                    Console.WriteLine("Ocupado por X");
                }
                else
                {
                    arr[0, 2] = valorO;
                    for (int f = 0; f < 3; f++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            Console.Write("   " + arr[f, c] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else if (linea == 4)
            {
                if (arr[1, 0] == valorX)
                {
                    Console.WriteLine("Ocupado por X");
                }
                else
                {
                    arr[1, 0] = valorO;
                    for (int f = 0; f < 3; f++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            Console.Write("   " + arr[f, c] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else if (linea == 5)
            {
                if (arr[1, 1] == valorX)
                {
                    Console.WriteLine("Ocupado por X");
                }
                else
                {
                    arr[1, 1] = valorO;
                    for (int f = 0; f < 3; f++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            Console.Write("   " + arr[f, c] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else if (linea == 6)
            {
                if (arr[1, 2] == valorX)
                {
                    Console.WriteLine("Ocupado por X");
                }
                else
                {
                    arr[1, 2] = valorO;
                    for (int f = 0; f < 3; f++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            Console.Write("   " + arr[f, c] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else if (linea == 7)
            {
                if (arr[2, 0] == valorX)
                {
                    Console.WriteLine("Ocupado por X");
                }
                else
                {
                    arr[2, 0] = valorO;
                    for (int f = 0; f < 3; f++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            Console.Write("   " + arr[f, c] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else if (linea == 8)
            {
                if (arr[2, 1] == valorX)
                {
                    Console.WriteLine("Ocupado por X");
                }
                else
                {
                    arr[2, 1] = valorO;
                    for (int f = 0; f < 3; f++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            Console.Write("   " + arr[f, c] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else if (linea == 9)
            {
                if (arr[2, 2] == valorX)
                {
                    Console.WriteLine("Ocupado por X");
                }
                else
                {
                    arr[2, 2] = valorO;
                    for (int f = 0; f < 3; f++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            Console.Write("   " + arr[f, c] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
        //Método el cual se utiliza para escribir la posición de la  ' X '.
        public void Cruz()
        {
            linea = int.Parse(Console.ReadLine());
            if (linea == 1)
            {
                if (arr[0, 0] == valorO)
                {
                    Console.WriteLine("Ocupado por O");
                }
                else
                {
                    arr[0, 0] = valorX;
                    for (int f = 0; f < 3; f++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            Console.Write("   " + arr[f, c] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else if (linea == 2)
            {
                if (arr[0, 1] == valorO)
                {
                    Console.WriteLine("Ocupado por O");
                }
                else
                {
                    arr[0, 1] = valorX;
                    for (int f = 0; f < 3; f++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            Console.Write("   " + arr[f, c] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else if (linea == 3)
            {
                if (arr[0, 2] == valorO)
                {
                    Console.WriteLine("Ocupado por O");
                }
                else
                {
                    arr[0, 2] = valorX;
                    for (int f = 0; f < 3; f++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            Console.Write("   " + arr[f, c] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else if (linea == 4)
            {
                if (arr[1, 0] == valorX)
                {
                    Console.WriteLine("Ocupado por X");
                }
                else
                {
                    arr[1, 0] = valorX;
                    for (int f = 0; f < 3; f++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            Console.Write("   " + arr[f, c] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else if (linea == 5)
            {
                if (arr[1, 1] == valorX)
                {
                    Console.WriteLine("Ocupado por X");
                }
                else
                {
                    arr[1, 1] = valorX;
                    for (int f = 0; f < 3; f++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            Console.Write("   " + arr[f, c] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else if (linea == 6)
            {
                if (arr[1, 2] == valorX)
                {
                    Console.WriteLine("Ocupado por X");
                }
                else
                {
                    arr[1, 2] = valorX;
                    for (int f = 0; f < 3; f++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            Console.Write("   " + arr[f, c] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else if (linea == 7)
            {
                if (arr[2, 0] == valorX)
                {
                    Console.WriteLine("Ocupado por X");
                }
                else
                {
                    arr[2, 0] = valorX;
                    for (int f = 0; f < 3; f++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            Console.Write("   " + arr[f, c] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else if (linea == 8)
            {
                if (arr[2, 1] == valorX)
                {
                    Console.WriteLine("Ocupado por X");
                }
                else
                {
                    arr[2, 1] = valorX;
                    for (int f = 0; f < 3; f++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            Console.Write("   " + arr[f, c] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else if (linea == 9)
            {
                if (arr[2, 2] == valorX)
                {
                    Console.WriteLine("Ocupado por X");
                }
                else
                {
                    arr[2, 2] = valorX;
                    for (int f = 0; f < 3; f++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            Console.Write("   " + arr[f, c] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
        public void Ganador()
        {
            //Validación del Jugador CRUZ
            if (arr[0, 0] == valorX && arr[0, 1] == valorX && arr[0, 2] == valorX)
            {
                Console.WriteLine("");
                Console.WriteLine("\\ Ganó -CRUZ-");
            }
            else if (arr[0, 0] == valorX && arr[1, 0] == valorX && arr[2, 0] == valorX)
            {
                Console.WriteLine("");
                Console.WriteLine("\\ Ganó -CRUZ-");
            }
            else if (arr[0, 1] == valorX && arr[1, 1] == valorX && arr[2, 1] == valorX)
            {
                Console.WriteLine("");
                Console.WriteLine("\\ Ganó -CRUZ-");
            }
            else if (arr[0, 2] == valorX && arr[1, 2] == valorX && arr[2, 2] == valorX)
            {
                Console.WriteLine("");
                Console.WriteLine("\\ Ganó -CRUZ-");
            }
            else if (arr[0, 0] == valorX && arr[1, 1] == valorX && arr[2, 2] == valorX)
            {
                Console.WriteLine("");
                Console.WriteLine("\\ Ganó -CRUZ-");
            }
            else if (arr[2, 0] == valorX && arr[1, 1] == valorX && arr[0, 2] == valorX)
            {
                Console.WriteLine("");
                Console.WriteLine("\\ Ganó -CRUZ-");
            }
            else if (arr[2, 0] == valorX && arr[2, 1] == valorX && arr[2, 2] == valorX)
            {
                Console.WriteLine("");
                Console.WriteLine("\\ Ganó -CRUZ-");
            }

            //INICIA VALIDACIÓN DEL CIRCULO
            else if (arr[0, 0] == valorO && arr[0, 1] == valorO && arr[0, 2] == valorO)
            {
                Console.WriteLine("");
                Console.WriteLine("\\ Ganó el -Circulo-");
            }
            else if (arr[0, 0] == valorO && arr[1, 0] == valorO && arr[2, 0] == valorO)
            {
                Console.WriteLine("");
                Console.WriteLine("\\ Ganó el -Circulo-");
            }
            else if (arr[1, 0] == valorO && arr[1, 1] == valorO && arr[1, 2] == valorO)
            {
                Console.WriteLine("");
                Console.WriteLine("\\ Ganó el -Circulo-");
            }
            else if (arr[0, 1] == valorO && arr[1, 1] == valorO && arr[2, 1] == valorO)
            {
                Console.WriteLine("");
                Console.WriteLine("\\ Ganó el -Circulo-");
            }
            else if (arr[0, 2] == valorO && arr[1, 2] == valorO && arr[2, 2] == valorO)
            {
                Console.WriteLine("");
                Console.WriteLine("\\ Ganó el -Circulo-");
            }
            else if (arr[0, 0] == valorO && arr[1, 1] == valorO && arr[2, 2] == valorO)
            {
                Console.WriteLine("");
                Console.WriteLine("\\ Ganó el -Circulo-");
            }
            else if (arr[0, 2] == valorO && arr[1, 1] == valorO && arr[2, 0] == valorO)
            {
                Console.WriteLine("");
                Console.WriteLine("\\ Ganó el -Circulo-");
            }
        }
    }
}
               
     
