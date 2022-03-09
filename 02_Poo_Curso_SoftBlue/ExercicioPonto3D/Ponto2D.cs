using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPonto3D
{
    public class Ponto2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Ponto2D(double x, double y) {
            this.X = x;
            this.Y = y;
        }

        public string Imprimir()
        {
            return "x = " + X + ", y = " + Y;
        }


    }
}
