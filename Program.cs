using System;

namespace DescontosMinhaLojaACME2000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valorProduto;
            decimal valorDesconto;

            Console.WriteLine("Bem vindo a loja ACME 2000!");
            Console.WriteLine("Vamos calcular o valor de desconto!");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            Console.Write("Informe o valor do produto: ");
            valorProduto = decimal.Parse(Console.ReadLine());

            Console.Write("Informe a porcentagem de desconto: ");
            valorDesconto = decimal.Parse(Console.ReadLine());

            // Valida se a taxa de desconto é maior que 50% ou menor que 0%
            if(valorDesconto > 50 || valorDesconto < 0)
            {
                Console.WriteLine("A taxa de desconto é inválida!");
                return; // Para o programa.
            }

            // Verifica se o desconto é valido para produtos de até 100 reais.
            if (valorProduto < 100 && valorDesconto > 10)
            {
                Console.WriteLine("A taxa de desconto é inválida!");
                return; // Para o programa.
            }
            // Verifica se o desconto é valido para produtos de até 200 reais.
            else if (valorProduto < 200 && valorDesconto > 20)
            {
                Console.WriteLine("A taxa de desconto é inválida!");
                return; // Para o programa.  
            }

            // Calcula o valor do desconto
            decimal valorFinal = valorProduto - (valorProduto * (valorDesconto / 100));

            // Mostra o valor final
            Console.WriteLine("");
            Console.Write("O valor final do produto é: ");

            Console.ForegroundColor = ConsoleColor.Green; // Muda a cor do console
            Console.WriteLine(valorFinal.ToString("C"));
            Console.ForegroundColor = ConsoleColor.White;

            // Aguarda o usuário digitar uma tecla.
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
        }
    }
}
