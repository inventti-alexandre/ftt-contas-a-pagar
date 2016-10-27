using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    class Quadrilatero
    {
        #region Atributos
        private int[] primeiro_ponto = new int[2];
        private int[] segundo_ponto = new int[2];
        private int[] terceiro_ponto = new int[2];
        private int[] quarto_ponto = new int[2];
        #endregion

        #region Propriedades
        public int[] PrimeiroPonto
        {
            get
            {
                return primeiro_ponto;
            }
            private set
            {
                primeiro_ponto = value;
            }
        }

        public int[] SegundoPonto
        {
            get
            {
                return segundo_ponto;
            }
            private set
            {
                segundo_ponto = value;
            }
        }
        public int[] TerceiroPonto
        {
            get
            {
                return terceiro_ponto;
            }
            private set
            {
                terceiro_ponto = value;
            }
        }
        public int[] QuartoPonto
        {
            get
            {
                return quarto_ponto;
            }
            private set
            {
                quarto_ponto = value;
            }
        }
        #endregion

        public Quadrilatero(int[] pri, int[] seg, int[] ter, int[] qua)
        {
            PrimeiroPonto = pri;
            SegundoPonto = seg;
            TerceiroPonto = ter;
            QuartoPonto = qua;
        }

        public static double CalcularDistancia(int[] pontoA, int[] pontoB)
        {
            double deltaX = Math.Pow(pontoB[0] - pontoA[0], 2);
            double deltaY = Math.Pow(pontoB[1] - pontoA[1], 2);
            return Math.Sqrt(deltaX + deltaY);
        }
    }
}
