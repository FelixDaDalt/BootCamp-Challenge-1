using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio1

            //int numero;
            //do{ 
            //Console.Write("Ingrese un numero positivo: ");
            //}while(int.TryParse(Console.ReadLine(), out numero) && numero < 0);

            //int suma=0;
            //for(int x=0; x< 100;x++)
            //{
            //    suma += numero;
            //    numero += 1;
            //}

            //Console.WriteLine($"suma= {suma}");

            #endregion

            #region Ejercicio2
            //int num1, num2;
            //do
            //{
            //    Console.WriteLine("Ingrese dos numeros distintos");
            //    Console.Write("Numero 1: ");
            //    num1 = int.Parse(Console.ReadLine());
            //    Console.Write("Numero 2: ");
            //    num2 = int.Parse(Console.ReadLine());

            //    if (num1 != num2)
            //    {
            //        if (num1 > num2)
            //        {
            //            int aux;
            //            aux = num1;
            //            num1 = num2;
            //            num2 = aux;
            //        }
            //        int suma = 0;
            //        for (int x = 0; x < num2; x += 7)
            //        {
            //            suma = num1 + 7;
            //        }

            //        Console.WriteLine($"Suma= {suma}");
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Son iguales!");
            //    }
            //} while (num1 == num2);
            #endregion

            #region Ejercicio3
            //int suma = 0, cont = 0, numero=0;
            //do {
            //    cont++;
            //    Console.Write("Ingrese un numero: ");
            //    numero=int.Parse(Console.ReadLine());

            //    suma += numero;


            //} while (suma <= 150);

            //Console.WriteLine($"Suma = {suma}");
            //Console.WriteLine($"Contador = {cont}");
            //Console.WriteLine($"Media = {suma/cont}");
            #endregion

            #region Ejercicio4
            //string nombre;
            //double salario;
            //int horas;

            //Console.Write("Nombre del trabajador: ");
            //nombre = Console.ReadLine();
            //Console.Write("Salario/hora: ");
            //salario = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Horas de trabajo: ");
            //horas = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Trabajador: {nombre}, salario: ${salario * horas}");
            #endregion


            Console.ReadKey();
        }
    }
}
