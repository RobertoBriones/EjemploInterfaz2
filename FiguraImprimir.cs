using System;


namespace EjemploInterfaz2
{
    public class FiguraImprimir
    {
        public void Imprimir<T>(T Valor) where T : IFigura
        {
            Console.WriteLine("Figura: {0}, Area: {1}, Perimetro: {2}", Valor.Nombre(), Valor.CalcularArea(), Valor.CalcularPerimetro());
        }

    }
}
