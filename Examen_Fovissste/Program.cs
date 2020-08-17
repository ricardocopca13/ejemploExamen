using System;
using System.Collections.Generic;

namespace Examen_Fovissste
{
    public class Program
    {
        public double altura, longitud, ancho;

        public List<double> valores1 = new List<double>();
        public List<double> valores2 = new List<double>();

        public double getVolumen(double altura, double longitud, double ancho)
        {
            double volumen;

            volumen = altura * longitud * ancho;
            
            return volumen;
        }

        public double suma(List<double> x1, List<double> x2, int posicion)
        {
            double suma = 0;
            suma = x1[posicion] + x2[posicion];

            return suma;
        }

        public double suma(int posicion)
        {
            double resultado = suma(valores1, valores2, posicion);

            return resultado;
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            for (int i=0; i<2;i++)
            {
                if (i==0)
                {
                    Console.Write("Igrese la altura 1: ");
                    p.altura = double.Parse(Console.ReadLine());

                    Console.Write("Igrese la longitud 1: ");
                    p.longitud = double.Parse(Console.ReadLine());

                    Console.Write("Igrese el ancho 1: ");
                    p.ancho = double.Parse(Console.ReadLine());

                    Console.WriteLine("El volumen del prisma 1 es: " + p.getVolumen(p.altura,p.longitud,p.ancho));

                    p.valores1.Add(p.altura);
                    p.valores1.Add(p.longitud);
                    p.valores1.Add(p.ancho);
                }
                else
                {
                    Console.Write("Igrese la altura 2: ");
                    p.altura = double.Parse(Console.ReadLine());

                    Console.Write("Igrese la longitud 2: ");
                    p.longitud = double.Parse(Console.ReadLine());

                    Console.Write("Igrese el ancho 2: ");
                    p.ancho = double.Parse(Console.ReadLine());

                    Console.WriteLine("El volumen del prisma 2 es: " + p.getVolumen(p.altura, p.longitud, p.ancho));

                    p.valores2.Add(p.altura);
                    p.valores2.Add(p.longitud);
                    p.valores2.Add(p.ancho);

                }


            }

            Console.WriteLine("a. La altura del prisma nuevo es: " + p.suma(0));
            Console.WriteLine("b. La longitud del prisma nuevo es: " + p.suma(1));
            Console.WriteLine("c. El ancho del prisma nuevo es: " + +p.suma(2));

            Console.ReadKey();
        }
    }
}
