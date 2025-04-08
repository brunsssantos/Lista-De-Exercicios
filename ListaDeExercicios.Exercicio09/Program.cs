using System.ComponentModel.Design;

namespace ListaDeExercicios.Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
            #region input de dados
            Console.WriteLine("Digite o primeiro número: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            int c = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region processamento
            int maior, meio, menor;

            if (a > b && a > c)
            {
                maior = a;
                if (b > c)
                {
                    meio = b;
                    menor = c;
                }
                else
                {
                    meio = c;
                    menor = b;
                }
            }
            else if (b > a && b > c)
            {
                maior = b;
                if (a > c)
                {
                    meio = a;
                    menor = c;
                }
                else
                {
                    meio = c;
                    menor = a;
                }
            }
            else
            {
                maior = c;
                if (a > b)
                {
                    meio = a;
                    menor = b;
                }
                else
                {
                    meio = b;
                    menor = a;
                }
            }
            #endregion

            #region output
            Console.WriteLine($"Ordem decrescente: {maior}, {meio}, {menor}");
            Console.ReadLine();
            #endregion
        }
    }
}

