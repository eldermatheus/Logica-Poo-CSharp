using System;

namespace Banco

{
    class Program
    {
        static void Main()
        {
            ContaBancaria c1 = new ContaBancaria("Elder Matheus", 123, 1300.00);

            Console.WriteLine(c1);

            c1.depositar(200.00);

            Console.WriteLine(c1);
        }
    }
}