using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularContasPagar
{
    abstract class Conta
    {
        private DateTime data_vencimento;
        private double valor_total;
        private int cod_cliente;
        private string endereco_cobranca;

        public DateTime DataVencimento { get; set; }
        public double ValorTotal {
            get
            {
                return valor_total;
            }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("O valor total não pode ser menor que zero");
                }
                else
                {
                    valor_total = value;
                }
            }
        }

        public int CodigoCliente {
            get
            {
                return cod_cliente;
            }
            private set
            {
                if (value > 0)
                {
                    throw new Exception("O código do cliente não pode ser zero");
                }
                else
                {
                    cod_cliente = value;
                }
            }
        }

        public string EnderecoCobranca {
            get
            {
                return endereco_cobranca;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("O endereço não pode ser vazio");
                }
                else
                {
                    endereco_cobranca = value;
                }
            }
        }

        public abstract double CalcularAumentoAnual(double taxa);
        public abstract double CalcularValorParcelamento(int num_parcelas);
    }
}
