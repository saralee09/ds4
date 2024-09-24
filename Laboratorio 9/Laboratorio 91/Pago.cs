using System;

public class Pago
{
    public decimal Precio { get; set; }
    public string FormaDePago { get; set; }
    public string NumeroDeCuenta { get; set; }

    public void SolicitarDatos()
    {
        Console.WriteLine("Ingresa el precio del producto:");
        Precio = ObtenerPrecioValido();

        Console.WriteLine("Ingresa la forma de pago (efectivo o tarjeta):");
        FormaDePago = Console.ReadLine().ToLower();

        if (FormaDePago == "tarjeta")
        {
            Console.WriteLine("Ingresa el número de cuenta (16 dígitos):");
            NumeroDeCuenta = ObtenerNumeroDeCuentaValido();
        }
    }

    private decimal ObtenerPrecioValido()
    {
        decimal precio;
        while (!decimal.TryParse(Console.ReadLine(), out precio) || precio <= 0)
        {
            Console.WriteLine("Por favor, ingresa un precio válido (positivo):");
        }
        return precio;
    }

    private string ObtenerNumeroDeCuentaValido()
    {
        string numeroCuenta;
        while (true)
        {
            numeroCuenta = Console.ReadLine();
            if (numeroCuenta.Length == 16 && long.TryParse(numeroCuenta, out _))
            {
                break;
            }
            Console.WriteLine("Por favor, ingresa un número de cuenta válido (16 dígitos):");
        }
        return numeroCuenta;
    }
}
