using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    class Retangulo : Paralelogramo
    {
        public Retangulo(int[] pri, int[] seg, int[] ter, int[] qua)
            : base(pri, seg, ter, qua)
        {

        }

        public override double CalcularArea(double ladoA, double ladoB)
        {
            return base.CalcularArea(ladoA, ladoB);
        }

        public override double CalcularPerimetro(double ladoA, double ladoB)
        {
            return base.CalcularPerimetro(ladoA, ladoB);
        }
    }
}
