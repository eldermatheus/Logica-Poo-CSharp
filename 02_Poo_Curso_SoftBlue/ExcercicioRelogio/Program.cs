using ExcercicioRelogio;
using System;


namespace Parametro

{
    class Program
    {
        static void Main()
        {
            Relogio p = new Relogio();

            p.AcertarRelogio(00, 47, 30);


            int hora = p.LerHora();
            int minuto = p.LerMinuto();
            int segundo = p.LerSegundo();

            Console.WriteLine("Hora: " + hora);
            Console.WriteLine("Minuto: " + minuto);
            Console.WriteLine("Segundo: " + segundo);

        }
    }
}