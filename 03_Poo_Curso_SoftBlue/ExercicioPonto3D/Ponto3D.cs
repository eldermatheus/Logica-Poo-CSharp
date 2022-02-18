using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPonto3D
{
    public class Ponto3D : Ponto2D
    {
        public double Z { get; set; }
        public Ponto3D(double x, double y, double z) : base(x, y)
        {            
            this.Z = z;            
        }
        
        public string Imprimir()
        {
            return "x = " + X + ", y = " + Y + ", z = " + Z;
        }

    }
}
