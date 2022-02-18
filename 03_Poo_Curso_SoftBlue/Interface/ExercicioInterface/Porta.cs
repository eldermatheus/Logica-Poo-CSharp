using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface
{
    class Porta : ICloneable
    {
        private readonly double altura;
        private readonly double largura;
        private bool aberta;

        public Porta() { 
        }
        public Porta(double altura, double largura)
        {   
            this.altura = altura;
            this.largura = largura;
            this.aberta = false;
        }

        public double Altura { 
            get { return altura; }
        }
        public double Largura
        {
            get { return largura; }
        }
        public bool Aberta
        {
            get { return aberta; }
        }

        public void Abrir() {
            this.aberta = true;
        }

        public void Fechar() {
            this.aberta = false;
        }

        public object Clone()
        {
            Porta portaClonada = new Porta(this.altura, this.largura);
            portaClonada.aberta = this.aberta;
            
            return portaClonada;
        }
        
        public override string ToString() {
            return $"Altura: {altura}, Largura: {largura}, Aberta: {aberta}";        
        }
    }
}
