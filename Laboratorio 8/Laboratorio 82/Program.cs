using System.Reflection.Emit;

namespace Laboratorio8
{
    public class cuenta
    {
        private string idCuenta;

        public cuenta (string prmtidCuenta)
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