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

            #region Ejercicio5
            //Random num = new Random();
            //bool salto = true;
            //double bicicleta = 0, moto = 0, auto = 0, camion = 0, error = 0;
            //int valor=0, total=0;
            //for (int x = 1; x <= 1000 && salto; x++)
            //{
            //    total = x;
            //    int vehiculo=num.Next(0,5);

            //    switch(vehiculo)
            //    {
            //        case 0: // bicicleta
            //            bicicleta++;
            //            valor = vehiculo;
            //            break;
            //        case 1: // Moto
            //            moto++;
            //            valor = vehiculo;
            //            break;
            //        case 2: // AUto
            //            auto++;
            //            valor = vehiculo;
            //            break;
            //        case 3: // Camion
            //            camion++;
            //            valor = vehiculo;
            //            break;
            //        case 4: // error
            //            if (valor != 4)
            //            {
            //                error++;
            //                valor = vehiculo;
            //                break;
            //            }
            //            else
            //            {
            //                error++;
            //                salto = false;
            //                break;
            //            } 

            //    }
            //}
            //Console.WriteLine($"Total Vehiculos: {total}");
            //Console.WriteLine($"Bicicleta: {bicicleta*total/100}%");
            //Console.WriteLine($"Moto: {moto * total / 100}%");
            //Console.WriteLine($"Auto: {auto * total / 100}%");
            //Console.WriteLine($"Camion: {camion * total / 100}%");

            //Console.WriteLine($"Errores: {error}");
            ///Me falto intervalo, no queria demorarme en este solo ejercicio mucho mas
            #endregion

            #region Ejercicio6
            //const double valorHora = 1.5;
            //int horas = 0;
            //double total=0;

            //Console.WriteLine("Cantidad de horas: ");
            //horas = Convert.ToInt32(Console.ReadLine());

            //for(int x=horas; x>=6; x-=6)
            //{
            //    horas -= 6;
            //    total += 5 * valorHora;

            //}
            //total += horas*valorHora;

            //Console.WriteLine($"ABonar: ${total}");


            #endregion

            #region Ejercicio7
            //int seg = 0;
            //int min = 0;
            //int horas = 0;
            //Console.Write("Ingrese segundos: ");
            //seg = Convert.ToInt32(Console.ReadLine());

            //while(seg >59)
            //{
            //    min++;
            //    seg -= 60;

            //}

            //while(min>59)
            //{
            //    horas++;
            //    min -= 60;
            //}

            //Console.WriteLine($"Segundos: {seg}");
            //Console.WriteLine($"Minutos: {min}");
            //Console.WriteLine($"Horas: {horas}");
            #endregion

            #region Ejercicio8
            //double salario;
            //Console.Write("Ingrese el salario: ");
            //salario = Convert.ToDouble(Console.ReadLine());

            //double aumento, servicios, nuevoSalario;
            //aumento = salario * 8 / 100;
            //servicios = ((salario + aumento) * 2.5 / 100);
            //nuevoSalario = salario+aumento-servicios;

            //Console.WriteLine($"Salario: ${salario}");
            //Console.WriteLine($"Aumento: +${aumento}");
            //Console.WriteLine($"subtotal: ${aumento+salario}");
            //Console.WriteLine($"Servicios: -${servicios}");
            //Console.WriteLine($"Nuevo Salario: ${nuevoSalario}");

            #endregion

            #region Ejercicio9
            //double b1, b2, a, area;
            //Console.Write("Ingrese la base 1: ");
            //b1=Convert.ToDouble(Console.ReadLine());
            //Console.Write("Ingrese la base 2: ");
            //b2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Ingrese la altura: ");
            //a = Convert.ToDouble(Console.ReadLine());
            //area = ((b1 + b2) / 2) * a;
            //Console.WriteLine($"Area: {area} mt2");
            #endregion

            Console.ReadKey();
        }
    }
}
