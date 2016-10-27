using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularContasPagar
{
    class Agua : Conta
    {
        private double volume_consumido;
        public double VolumeConsumido {
            get
            {
                return volume_consumido;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("O volume consumido não pode ser menor que zero");
                }
                else
                {
                    volume_consumido = value;
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