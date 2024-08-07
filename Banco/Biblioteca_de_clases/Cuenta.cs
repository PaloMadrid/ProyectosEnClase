namespace Biblioteca_de_clases
{
    public class Cuenta
    {
        private int dni;
        private string alias;
        private double saldo;
        private string tipoDeCuenta;
        private int cbu;

        public Cuenta(int dni, string alias, double saldo, string tipoDeCuenta, int cbu)
        {
            this.dni = dni;
            this.alias = alias;
            this.saldo = saldo;
            this.tipoDeCuenta = tipoDeCuenta;
            this.cbu = cbu;
        }

        public string MostrarInformacion()
        {
            return "DNI cliente: " + this.dni + " - Alias: " + this.alias + " - Tipo de cuenta: " + this.tipoDeCuenta + " - Saldo: " + this.saldo+ " - CBU: "+this.cbu;
        }
    }
}
