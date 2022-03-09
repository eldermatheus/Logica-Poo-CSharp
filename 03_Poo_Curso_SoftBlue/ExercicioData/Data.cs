using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioData
{
    public class Data
    {
        private readonly int dia;
        private readonly int mes;
        private readonly int ano;
        private readonly int hora12h;
        private readonly int hora24h;
        private readonly int minuto;
        private readonly int segundo;

        public Data(int dia, int mes, int ano) { 
            this.dia = dia;
            this.mes = mes; 
            this.ano = ano;
        }
        
        public Data(int dia, int mes, int ano, int hora, int minuto, int segundo) : this(dia, mes, ano)
        {
            this.hora = hora;
            this.minuto = minuto;
            this.segundo = segundo;
        }

        public void imprimir(string formato) {

            if (formato == "FORMATO_12H")
            {
                Console.WriteLine($"10 / 3 / 2000 10:30:10");
            }

            else { 
            
            }
        }
    }
}
