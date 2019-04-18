using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastecimentoApp
{
    class Abastecimento
    {
        private double ValorLitro, ValorPago, KmRodados;
        public Abastecimento(double ValorLido, double ValorPago, double KmRodados)
        {
            this.ValorLitro = ValorLitro;
            this.ValorPago = ValorPago;
            this.KmRodados = KmRodados;
        }
        public double MediaKmLitro()
        {
            return KmRodados / (ValorPago / ValorLitro);
        }
        public double MediaEmReais()
        {
            return ValorPago / KmRodados;
        }
    }
}
