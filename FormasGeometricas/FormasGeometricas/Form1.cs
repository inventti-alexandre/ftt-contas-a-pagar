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
        private Paralelogramo FormaGeometrica { get; set; }

        public Form1()
        {
            InitializeComponent();
            pnlCadastro.Enabled = false;
            pnlCalculo.Enabled = false;

            CarregarFormasGeometricas();
            int[] pontoA = { 0, 10 };
            int[] pontoB = { 20, 10 };
            int[] pontoC = { 20, 0 };
            int[] pontoD = { 0, 0 };

            //var quadrado = new Retangulo(pontoA, pontoB, pontoC, pontoD);
            //var perimetro = quadrado.CalcularPerimetro(Quadrilatero.CalcularDistancia(pontoA, pontoB), Quadrilatero.CalcularDistancia(pontoB, pontoC));
            //var area = quadrado.CalcularArea(Quadrilatero.CalcularDistancia(pontoA, pontoB), Quadrilatero.CalcularDistancia(pontoB, pontoC));
            //MessageBox.Show(perimetro.ToString() + " | " + area.ToString());
        }

        private void CarregarFormasGeometricas()
        {
            Dictionary<string, string> formas = new Dictionary<string, string>();
            formas.Add("", "Escolha uma forma");
            formas.Add("retangulo", "Retagulo");
            formas.Add("losangulo", "Losangulo");

            cbFormaGeometrica.DataSource = new BindingSource(formas, null);
            cbFormaGeometrica.DisplayMember = "Value";
            cbFormaGeometrica.ValueMember = "Key";
        }

        private void cbFormaGeometrica_SelectedValueChanged(object sender, EventArgs e)
        {
            InitTela();
            pnlCadastro.Enabled = !String.IsNullOrWhiteSpace(cbFormaGeometrica.SelectedValue.ToString());

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                CadastrarPontos();
                MessageBox.Show("Cadastrado com sucesso!");
                pnlCalculo.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void CadastrarPontos()
        {
            int[] pontoA = new int[2];
            int[] pontoB = new int[2];
            int[] pontoC = new int[2];
            int[] pontoD = new int[2];

            try
            {
                pontoA[0] = Convert.ToInt32(txtX1.Text);
                pontoA[1] = Convert.ToInt32(txtY1.Text);

                pontoB[0] = Convert.ToInt32(txtX2.Text);
                pontoB[1] = Convert.ToInt32(txtY2.Text);

                pontoC[0] = Convert.ToInt32(txtX3.Text);
                pontoC[1] = Convert.ToInt32(txtY3.Text);

                pontoD[0] = Convert.ToInt32(txtX4.Text);
                pontoD[1] = Convert.ToInt32(txtY4.Text);
            }
            catch (Exception)
            {
                throw new Exception("Os pontos devem ser números inteiros");
            }

            try
            {
                switch (cbFormaGeometrica.SelectedValue.ToString())
                {
                    case "retangulo":
                        FormaGeometrica = new Retangulo(pontoA, pontoB, pontoC, pontoD);
                        break;
                    case "losangulo":
                        FormaGeometrica = new Losangulo(pontoA, pontoB, pontoC, pontoD);
                        break;
                }
            }
            catch (Exception error)
            {
                throw new Exception(error.Message, error);
            }
        }

        private void btnCalcularArea_Click(object sender, EventArgs e)
        {
            var ladoA = Quadrilatero.CalcularDistancia(FormaGeometrica.PrimeiroPonto, FormaGeometrica.SegundoPonto);
            var ladoB = Quadrilatero.CalcularDistancia(FormaGeometrica.SegundoPonto, FormaGeometrica.TerceiroPonto);
            MessageBox.Show(FormaGeometrica.CalcularArea(ladoA, ladoB).ToString());
        }

        private void btnCalcularPerimetro_Click(object sender, EventArgs e)
        {
            var ladoA = Quadrilatero.CalcularDistancia(FormaGeometrica.PrimeiroPonto, FormaGeometrica.SegundoPonto);
            var ladoB = Quadrilatero.CalcularDistancia(FormaGeometrica.SegundoPonto, FormaGeometrica.TerceiroPonto);
            MessageBox.Show(FormaGeometrica.CalcularPerimetro(ladoA, ladoB).ToString());
        }

        private void InitTela()
        {
            txtX1.Clear();
            txtX2.Clear();
            txtX3.Clear();
            txtX4.Clear();
            txtY1.Clear();
            txtY2.Clear();
            txtY3.Clear();
            txtY4.Clear();

            pnlCadastro.Enabled = false;
            pnlCalculo.Enabled = false;
        }
    }
}