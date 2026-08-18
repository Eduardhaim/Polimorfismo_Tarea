public class Rectangulo : Forma
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    public override double CalcularArea()
    {
        return Ancho * Alto;
    }
}