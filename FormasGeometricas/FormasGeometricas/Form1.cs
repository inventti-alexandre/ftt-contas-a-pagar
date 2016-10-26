using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormasGeometricas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int[] pontoA = { 0, 10 };
            int[] pontoB = { 20, 10 };
            int[] pontoC = { 20, 0 };
            int[] pontoD = { 0, 0 };

            var quadrado = new Retangulo(pontoA, pontoB, pontoC, pontoD);
            var perimetro = quadrado.CalcularPerimetro(Quadrilatero.CalcularDistancia(pontoA, pontoB), Quadrilatero.CalcularDistancia(pontoB, pontoC));
            var area = quadrado.CalcularArea(Quadrilatero.CalcularDistancia(pontoA, pontoB), Quadrilatero.CalcularDistancia(pontoB, pontoC));
            MessageBox.Show(perimetro.ToString() + " | " + area.ToString());
        }
    }
}
