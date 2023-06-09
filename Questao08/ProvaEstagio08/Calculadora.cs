using System;

namespace ProvaEstagio08
{
    class Calculadora : VerificacaoValores
    {

        private double ValorDesconto { get; set; }

        public Calculadora(double valor1, double valor2) : base(valor1, valor2) 
        {        
        }

        public object SomaDeDoisValores()
        {
            if (VerificaValorSoma())
            {
                return (int)Valor1 + (int)Valor2;
            }
            else
            {
                return "Os dois valores devem ser positivos e inteiros!";
            }

        }

        public object MultiplicacaoDeDoisValores()
        {
            if (VerificaValorMultiplicacao())
            {
                return Valor1 * Valor2;
            }
            else
            {
                return "O segundo valor não pode ser negativo";
            }
        }
      
        public double CalculaDesconto()
        {
            ValorDesconto = (Valor1 * (100- Valor2)) / 100;
            return ValorDesconto;

        }
    }
}
