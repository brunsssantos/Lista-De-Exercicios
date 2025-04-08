using System.Reflection.Metadata.Ecma335;

namespace ListaDeExercicios.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para verificar se um número é primo.
            #region input de dados
            while (true)
            {
                Console.WriteLine("Digite um número: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                #endregion

                #region processamento
                bool primo = true;

                if (numero <= 1)
                {
                    primo = false;
                }
                else
                {
                    for (int i = 2; i <= Math.Sqrt(numero); i++)
                    {
                        if (numero % i == 0)
                        {
                            primo = false;
                            break;
                        }
                    }
                }
                #endregion

                #region output
                if (primo)
                    Console.WriteLine($"O {numero} é primo");

                else
                    Console.WriteLine($"O {numero} não é primo");

                Console.ReadLine();
                #endregion
            }
        }
    }
}
