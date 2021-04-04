using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero entre el 1 y 12 para indicar mes");

            string num = Console.ReadLine();
            string numero;
            switch (num)
            {
                case "1":
                    numero = "Enero";
                    break;
                case "2":
                    numero = "Febrero";
                    break;
                case "3":
                    numero = "Marzo";
                    break;
                case "4":
                    numero = "Abril";
                    break;
                case "5":
                    numero = "Mayo";
                    break;
                case "6":
                    numero = "Junio";
                    break;
                case "7":
                    numero = "Julio";
                    break;
                case "8":
                    numero = "Agosto";
                    break;
                case "9":
                    numero = "Septiembre";
                    break;
                case "10":
                    numero = "Octubre";
                    break;
                case "11":
                    numero = "Noviembre";
                    break;
                case "12":
                    numero = "Diciembre";
                    break;
                default:
                    numero = "SOLO SE PERMITEN NUMEROS DEL 1 AL 12";
                    break;
            }

            Console.WriteLine("==============================");
            Console.WriteLine(numero);
            Console.WriteLine("==============================");

            Console.ReadKey();
        }
    }
    }
