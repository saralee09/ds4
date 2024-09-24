using System;

public class Programa
{
    public static void Main(string[] args)
    {
        Pago pago = new Pago();
        pago.SolicitarDatos();

        Console.WriteLine("Precio: " + pago.Precio);
        Console.WriteLine("Forma de pago: " + pago.FormaDePago);

        if (pago.FormaDePago == "tarjeta")
        {
            Console.WriteLine("Número de cuenta: " + pago.NumeroDeCuenta);
        }
    }
}
