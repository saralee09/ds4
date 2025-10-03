using System.Reflection.Emit;

namespace Laboratorio8
{
    public class Cuenta
    {
        private string idCuenta;

        public Cuenta(string prmtidCuenta)
        {
            this.idCuenta = prmtidCuenta;
            System.Console.WriteLine("Cuenta.CalcularIntereses() Efectuado para la cuenta {0}", this.idCuenta);

        }

        public string getIdCuenta()
        {
            return this.idCuenta;
        }
    }
}