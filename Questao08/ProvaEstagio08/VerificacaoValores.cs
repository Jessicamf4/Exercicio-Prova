using System;

namespace ProvaEstagio08
{
    class VerificacaoValores
    {

        public double Valor1 { get; set; }
        public double Valor2 { get; set; }

        public VerificacaoValores(double valor1, double valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;

        }

        protected bool VerificaValorSoma()
        {
            if ((Valor1 > 0) && (Math.Round(Valor1) == Valor1))
            {
                if (Valor2 > 0 && (Math.Round(Valor2) == Valor2))
                {
                    return true;
                }
                else { return false; }
            }
            else
            {
                return false;
            }

        }

        protected bool VerificaValorMultiplicacao()
        {
            if (Valor2 > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
