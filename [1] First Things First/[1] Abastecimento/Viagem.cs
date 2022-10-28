using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__Abastecimento
{
    class Viagem
    {
        private double valorLitro, valorPago, kmRodados;
        
        public void SetValorLitro(double v)
        {
            if (v > 0) valorLitro = v;
        }
        public void SetValorPago(double v)
        {
            if (v > 0) valorPago = v;
        }
        public void SetKmRodados(double v)
        {
            if (v > 0) kmRodados = v;
        }
        public double MediaKmLitro()
        {
            return kmRodados / (valorPago / valorLitro);
        }
        public double MediaReaisKm()
        {
            return valorPago / kmRodados;
        }
    }
}
