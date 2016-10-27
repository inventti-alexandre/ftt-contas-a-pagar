using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularContasPagar
{
    public partial class Form1 : Form
    {
        public const double AUMENTO_ANUAL_AGUA = 5.0;
        public const double AUMENTO_ANUAL_INTERNET = 2.5;
        public const double AUMENTO_ANUAL_ENERGIA_ELETRICA = 4.0;
        private EnergiaEletrica EnergiaEletrica;

        public Form1()
        {
            InitializeComponent();
            try
            {
                EnergiaEletrica = new EnergiaEletrica();
                EnergiaEletrica.CodigoCliente = 123;
                EnergiaEletrica.ConsumoEnergia = 200;
                EnergiaEletrica.DataVencimento = new DateTime().Date;
                EnergiaEletrica.EnderecoCobranca = "Rua Juca";
                EnergiaEletrica.ValorTotal = 120.50;

                var numParcelas = 8;
                var message = "";
                message += "Aumento anual com taxa de " + AUMENTO_ANUAL_ENERGIA_ELETRICA + "% = R$" + Math.Round(EnergiaEletrica.CalcularAumentoAnual(AUMENTO_ANUAL_ENERGIA_ELETRICA), 2) + Environment.NewLine;
                message += numParcelas + " parcelas iguais de R$" + Math.Round(EnergiaEletrica.CalcularValorParcelamento(numParcelas), 2);
                MessageBox.Show(message);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}