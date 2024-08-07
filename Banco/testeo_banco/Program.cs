using Biblioteca_de_clases;

namespace testeo_banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1;
           
            Cuenta cuenta2 = new Cuenta(3698745,"juan",50000,"Cuenta corriente",657985465);
            int dni;
            string alias;
            double saldo;
            string tipoDeCuenta;
            int cbu;


            Console.WriteLine("ingrese su dni:");
            dni=int.Parse( Console.ReadLine());

            Console.WriteLine("Alias:");
            alias = Console.ReadLine();

            Console.WriteLine("saldo:");
            saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("tpo de cuenta:");
            tipoDeCuenta = (Console.ReadLine());

            Console.WriteLine("cbu:");
            cbu = int.Parse(Console.ReadLine());

            cuenta1 = new Cuenta(dni, alias, saldo, tipoDeCuenta, cbu);

            Console.WriteLine(cuenta1.MostrarInformacion());
        }
    }
}
