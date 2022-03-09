using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLampada
{
    public class Lampada
    {
        public bool Ligada { get; set; }

        public Lampada() {
            
        }

        /*public void Ligar() 
        {
            if (Ligada)
            {
                Console.WriteLine("A lâmpada já está ligada");
            }
            else Ligada = true;
            Console.WriteLine("Aguarde. Ligando a lâmpada...");
        }   

        public void Desligar()
        {
            if (!Ligada)
            {
                Console.WriteLine("A lâmpada já está desligada");
            }
            else Ligada = false;
            Console.WriteLine("Aguarde. Desligando a lâmpada...");
        }*/

        public void Imprimir() {

            if (Ligada) {
                Console.WriteLine("Lâmpada ligada");
            }
            else Console.WriteLine("Lâmpada desligada");

        }
    }
}
