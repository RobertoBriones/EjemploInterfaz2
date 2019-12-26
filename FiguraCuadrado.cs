

namespace EjemploInterfaz2
{
    public class FiguraCuadrado : FiguraPadre, IFigura
    {
        public int Lado { get; set; }


        public string CalcularPerimetro()
        {

            Perimetro = (Lado * 4).ToString();
            return Perimetro;
        }

        public string CalcularArea()
        {
            Area = (Lado * Lado).ToString();
            return Area;
        }

        public string Nombre()
        {
            NombreFigura = "Cuadrado";
            return NombreFigura;
        }
    }
}
