using ProvaEstagio08;

class Program
{
    static void Main()
    {
        int tipoDeCalculo = 0;

        while (tipoDeCalculo != 4)
        {
            Console.WriteLine("Qual o tipo de cálculo deseja fazer? 1 - soma, 2 - multiplicação, 3 - desconto de um produto, 4 - FINALIZAR");
            tipoDeCalculo = int.Parse(Console.ReadLine());

            if (tipoDeCalculo == 1)
            {
                Console.WriteLine("Para fazermos a SOMA de dois números, digite o primeiro valor, sendo que ele deve ser positivo e inteiro:");
                int valor1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Agora, digite o segundo valor, sendo que ele também deve ser positivo e inteiro:");
                int valor2 = int.Parse(Console.ReadLine());

                Calculadora soma = new Calculadora(valor1, valor2);
                Console.WriteLine("Resultado: " + soma.SomaDeDoisValores());
            }

            if (tipoDeCalculo == 2)
            {
                Console.WriteLine("Para fazermos a MULTIPLICAÇÃO de dois números, digite o primeiro valor, sendo que ele pode ser negativo:");
                double valor1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Agora, digite o segundo valor, que deve ser positivo:");
                double valor2 = double.Parse(Console.ReadLine());

                Calculadora multiplicacao = new Calculadora(valor1, valor2);
                Console.WriteLine("Resultado: " + multiplicacao.MultiplicacaoDeDoisValores());
            }

            if (tipoDeCalculo == 3)
            {
                Console.WriteLine("Para fazermos o cálculo de DESCONTO de um determinado valor, digite o valor no qual será aplicado o desconto:");
                double valor1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Agora, digite o valor do desconto, em porcentagem:");
                double valor2 = double.Parse(Console.ReadLine());

                Calculadora desconto = new Calculadora(valor1, valor2);
                Console.WriteLine("Resultado: " + desconto.CalculaDesconto());
            }

            Console.WriteLine();
        }


    }
}