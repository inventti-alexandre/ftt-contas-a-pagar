using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    class Paralelogramo : Quadrilatero
    {
        public Paralelogramo(int[] pri, int[] seg, int[] ter, int[] qua) 
            :base(pri, seg, ter, qua)
        {
            
        }

        public virtual double CalcularArea(double ladoA, double ladoB)
        {
            return ladoA * ladoB;
        }

        public virtual double CalcularPerimetro(double ladoA, double ladoB)
        {
            return 2 * (ladoA + ladoB);
        }
    }
}