using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        double numa, numb, ans;

        Console.WriteLine("Introduce la medida de un lado del rectángulo, lado A: ");
        numa = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduce la medida de otro lado del rectángulo, lado B: ");
        numb = Convert.ToDouble(Console.ReadLine());

        CalculosMatematicos calculos = new CalculosMatematicos();

        ans = calculos.CalculoPerimetro(numa, numb);

        Console.WriteLine("El perímetro del rectángulo de lados {0} y {1} es {2}", numa, numb, ans);
    }
}

internal class CalculosMatematicos
{
    public double CalculoArea(double r, double pi)
    {
        double area = pi * (r * r);
        return area;
    }

    public double CalculoPerimetro(double A, double B)
    {
        double perimetro = 2 * (A + B);
        return perimetro;
    }
}
