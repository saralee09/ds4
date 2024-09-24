using System;

public class Triangulo
{
    public int Lado1 { get; set; }
    public int Lado2 { get; set; }
    public int Lado3 { get; set; }

    public void SolicitarDatos()
    {
        Console.WriteLine("Ingresa el primer lado:");
        Lado1 = ObtenerLadoValido();

        Console.WriteLine("Ingresa el segundo lado:");
        Lado2 = ObtenerLadoValido();

        Console.WriteLine("Ingresa el tercer lado:");
        Lado3 = ObtenerLadoValido();

        if (EsTrianguloValido())
        {
            DeterminarTipoDeTriangulo();
        }
        else
        {
            Console.WriteLine("Los lados ingresados no forman un triángulo válido.");
        }
    }

    private int ObtenerLadoValido()
    {
        int lado;
        while (!int.TryParse(Console.ReadLine(), out lado) || lado <= 0)
        {
            Console.WriteLine("Por favor, ingresa un valor positivo:");
        }
        return lado;
    }

    private bool EsTrianguloValido()
    {
        return (Lado1 + Lado2 > Lado3) && (Lado1 + Lado3 > Lado2) && (Lado2 + Lado3 > Lado1);
    }

    private void DeterminarTipoDeTriangulo()
    {
        if (Lado1 == Lado2 && Lado2 == Lado3)
        {
            Console.WriteLine("Es un triángulo equilátero.");
        }
        else if (Lado1 == Lado2 || Lado1 == Lado3 || Lado2 == Lado3)
        {
            Console.WriteLine("Es un triángulo isósceles.");
        }
        else
        {
            Console.WriteLine("Es un triángulo escaleno.");
        }
    }
}
