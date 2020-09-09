using System;

namespace ConceptosPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            RealizarTarea();

        }

        static void RealizarTarea() {

            Punto origen = new Punto();

            Punto destino = new Punto(128,50);

            double distancia = origen.MedirDistancia(destino);
            Console.WriteLine("La distancia entre estos dos puntos es de: "+distancia);

            Console.WriteLine("Numero de objetos creados: " + Punto.contanto());

        }

       


    }
}
