using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularContasPagar
{
    class EnergiaEletrica : Conta
    {
        private int consumo_energia;
        public int ConsumoEnergia {
            get
            {
                return consumo_energia;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("O consumo de energia não pode ser menor que zero");
                }
                else
                {
                    consumo_energia = value;
                }
            }
        }

        public override double CalcularAumentoAnual(double taxa)
        {
            throw new NotImplementedException();
        }

        public override double CalcularValorParcelamento(int num_parcelas)
        {
            throw new NotImplementedException();
        }
    }
}