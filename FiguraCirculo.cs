

namespace EjemploInterfaz2
{
    class FiguraCirculo : FiguraPadre, IFigura
    {
        public int Radio;
        public string CalcularArea()
        {
            Area = (3.14 * Radio * Radio).ToString();
            return Area;
        }

        public string CalcularPerimetro()
        {
            Perimetro = ((int)(2 * 3.14 * Radio)).ToString();
            return Perimetro;
        }

        public string Nombre()
        {
            NombreFigura = "Circulo";
            return NombreFigura;
        }
    }
}
