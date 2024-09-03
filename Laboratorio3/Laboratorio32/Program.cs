
internal class Program
{
    private static void Main(string[] args)
    {
        double radio, ans;

        Console.WriteLine("Introduce el radio del circulo: ");
        radio = Convert.ToDouble(Console.ReadLine());

        CalculosMatematicos calculos = new CalculosMatematicos();

        ans = calculos.CalculoArea(radio, 3.1416);

        Console.WriteLine("El área del círculo con radio {0} , es {1}", radio, ans);
    }
}

internal class CalculosMatematicos
{
    public int Calcular(int a, int b)
    {
        int suma = a + b;
        int resta = a - b;
        return suma * resta;
    }

    public double CalculoArea(double r, double pi)
    {
        double area = pi * (r * r);
        return area;
    }
}


