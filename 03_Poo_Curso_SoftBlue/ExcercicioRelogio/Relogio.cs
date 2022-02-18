using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcercicioRelogio
{
    public class Relogio
    {
        public Ponteiro ponteiroHora = new Ponteiro();
        public Ponteiro ponteiroMinuto = new Ponteiro();
        public Ponteiro ponteiroSegundo = new Ponteiro();

        public void AcertarRelogio(int hora, int minuto, int segundo)
        {
            ponteiroHora.posicao = hora;
            ponteiroMinuto.posicao = minuto;
            ponteiroSegundo.posicao = segundo;
        }

        public int LerHora()
        {
            return ponteiroHora.posicao;
        }

        public int LerMinuto()
        {
            return ponteiroMinuto.posicao;
        }

        public int LerSegundo()
        {
            return ponteiroSegundo.posicao;
        }

     
    }
}
