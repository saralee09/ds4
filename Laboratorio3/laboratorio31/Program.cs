internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2, ans;

        Console.WriteLine("Introduce el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        CalculosMatematicos calculos = new CalculosMatematicos();

        ans = calculos.Calcular(num1, num2);

        Console.WriteLine("El resultado de la operación ({0} + {1}) * ({0} - {1}) es {2}", num1, num2, ans);
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
}
