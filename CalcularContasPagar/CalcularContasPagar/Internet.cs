using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularContasPagar
{
    class Internet : Conta
    {
        private string pacote;
        public string Pacote {
            get
            {
                return pacote;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("O pacote de internet precisa ser informado");
                }
                else
                {
                    pacote = value;
                }
            }
        }

        public override double CalcularAumentoAnual(double taxa)
        {
            return (ValorTotal * taxa) / 100;
        }

        public override double CalcularValorParcelamento(int num_parcelas)
        {
            return ValorTotal / num_parcelas;
        }
    }
}