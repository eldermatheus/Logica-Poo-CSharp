using System;

namespace Parametro

{ 
    class Program
    {
        static void Main()
        {
            Matematica m = new Matematica();
            float a = 10f;
            float b = 4f;
            double r1, r2, r3;
            double r4;
            m.SomaDimMultDiv(a,b, out r1, out r2, out r3, out r4);
            
            Console.WriteLine($"Números passados: " + a + " e " + b + "\r\n" +
                $"Soma: {r1} \r\n" +
                $"Diferença: {r2} \r\n" +
                $"Multiplicação: {r3} \r\n" +
                $"Divisão: {r4}", r1, r2, r3, r4);
        }

        class Matematica {

            public void SomaDimMultDiv
            (
                float a,
                float b,
                out double rs,
                out double rdif,
                out double rm,
                out double rd
            ) 
            {
                rs = a + b;
                rdif = a - b;
                rm = a * b;
                rd = (double)  a / b;
            }
        }       
    }
}