using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicios.Ejercicio1;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elija una opcion:\r\n 1-Cuadrado\r\n 2-Rectangulo\r\n 3-Triangulo");
            String options = Console.ReadLine();

            switch (options)
            {
                case "1":
                    Console.WriteLine("ingrese un lado del cuadrado:");
                    int lado1 = ingresarNumeroLado();
                    int area = new Cuadrado(lado1).area();
                    int peri = new Cuadrado(lado1).perimetro();
                    Console.WriteLine($"Area del cuadrado = {area}\r\nPerimetro del cuadrado ={peri}");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("ingrese ancho del rectangulo:");
                    int lado2 = ingresarNumeroLado();
                    Console.WriteLine("ingrese alto de rectangulo:");
                    int lado3 = ingresarNumeroLado();
                    int area2 = new Rectangulo(lado2,lado3).area();
                    int peri2 = new Rectangulo(lado2,lado3).perimetro();
                    Console.WriteLine($"Area del rectangulo = {area2}\r\nPerimetro del rectangulo ={peri2}");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine("ingrese el primer Lado del triangulo:");
                    int lad1 = ingresarNumeroLado();
                    Console.WriteLine("ingrese el segundo lado del triangulo:");
                    int lad2 = ingresarNumeroLado();
                    Console.WriteLine("ingrese el tercer lado del triangulo:");
                    int lad3 = ingresarNumeroLado();
                    int area3 = new Triangulo(lad1, lad2, lad3).area();
                    int peri3 = new Triangulo(lad1, lad2, lad3).perimetro();
                    Console.WriteLine($"Area del triangulo = {area3}\r\nPerimetro del triangulo ={peri3}");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("no existe esa opcion!");
                    break;
            }
        }

        public static int ingresarNumeroLado()
        {
            int ladoRecursivo;
            try
            {
                String lado = Console.ReadLine();
                ladoRecursivo = int.Parse(lado);
            }
            catch
            {
                Console.WriteLine("ingrese un valor numerico");
                ladoRecursivo = ingresarNumeroLado();
            }

            return ladoRecursivo;


        }
    }
}
