using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_Area__Superficie_JOSE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 1;
            while (a == 1)

            { // CONVERSOR DE SUPERFICIE AREA
                Console.WriteLine(" Conversor de AREA. (SUPERFICIE) ");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(" 1).METRO CUADRADO -PIE CUADRADO  ");
                Console.WriteLine(" 2).PIE CUADRADO -VARA CUADRADA ");
                Console.WriteLine(" 3).VARA CUADRADA -YARDA CUADRADA ");
                Console.WriteLine(" 4).YARDA CUADRADA -METRO CUADRADO ");
                Console.WriteLine(" 5).METRO CUADRADO -TAREAS ");
                Console.WriteLine(" 6).TAREAS -MANZANAS ");
                Console.WriteLine(" 7). MANZANAS -HECTAREAS ");
                Console.WriteLine("0). Para pasar salir ");
                Console.WriteLine(" ");

                int Ar = Convert.ToInt32(Console.ReadLine());
                if (Ar == 1)
                {
                    Console.WriteLine("Cantidad en metro cuadrado: ");
                    var are1 = Convert.ToInt32(Console.ReadLine());
                    double are2 = are1 * 10.764;
                    Console.WriteLine("Pies cuadrados = " + are2);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }

                else if (Ar == 2)
                {
                    Console.WriteLine("Cantidad en pies cuadrados: ");
                    var are3 = Convert.ToInt32(Console.ReadLine());
                    double are4 = are3 / 3;
                    Console.WriteLine("Varas cuadradas = " + are4);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (Ar == 3)
                {
                    Console.WriteLine("Cantidad en varas cuadradas: ");
                    var are5 = Convert.ToInt32(Console.ReadLine());
                    double are6 = are5 / 1.1664;
                    Console.WriteLine("Yardas cuadradas = " + are6);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (Ar == 4)
                {
                    Console.WriteLine("Cantidad en yardas cuadradas: ");
                    var are7 = Convert.ToInt32(Console.ReadLine());
                    double are8 = are7 / 0.836127;
                    Console.WriteLine("metros cuadrados = " + are8);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();

                }
                else if (Ar == 5)
                {
                    Console.WriteLine("Cantidad de metros cuadrados: ");
                    var are9 = Convert.ToInt32(Console.ReadLine());
                    double are10 = are9 * 0.0015903307888;
                    Console.WriteLine("Tareas = " + are10);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();

                }
                else if (Ar == 6)
                {
                    Console.WriteLine("Cantidad de Tareas: ");
                    var are11 = Convert.ToInt32(Console.ReadLine());
                    double are12 = (628.8 / 70.44 * 100) * are11;
                    Console.WriteLine("manzanas = " + are12);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();

                }
                else if (Ar == 5)
                {
                    Console.WriteLine("Cantidad de manzanas: ");
                    var are13 = Convert.ToInt32(Console.ReadLine());
                    double are14 = are13 * 0.6972;
                    Console.WriteLine("hectareas = " + are14);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();

                }


                else if (Ar == 0)
                {
                    a = 1;
                }
                else
                {
                    Console.WriteLine("Opcion invalida!");
                    Console.WriteLine("Presiona enter para SALIR ");

                }
            }
        }
    }
}