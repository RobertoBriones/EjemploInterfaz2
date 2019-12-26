
namespace EjemploInterfaz2
{
    public class FiguraTriangulo : FiguraPadre, IFigura
    {
        public int Base { get; set; }
        public int Altura { get; set; }



        public string CalcularPerimetro()
        {

            Perimetro = (Base * 3).ToString();
            return Perimetro;
        }


        public string CalcularArea()
        {
            Area = (Base * Altura / 2).ToString();
            return Area;
        }

        public string Nombre()
        {
            NombreFigura = "Triangulo";
            return NombreFigura;
        }
    }
}
