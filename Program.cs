using System;

namespace EjemploInterfaz2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FiguraImprimir a = new FiguraImprimir();

            var Figura1 = new FiguraCuadrado();
            Figura1.Lado = 5;
            a.Imprimir(Figura1);

            var Figura2 = new FiguraTriangulo();
            Figura2.Base = 5;
            Figura2.Altura = 10;
            a.Imprimir(Figura2);

            var Figura3 = new FiguraCirculo();
            Figura3.Radio = 5;
            a.Imprimir(Figura3);

            Console.Read();
        }
    }
}
