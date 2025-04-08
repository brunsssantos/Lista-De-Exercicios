namespace ListaDeExercicios.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                //Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
                Console.WriteLine("Informe o número: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é par");
                }
                else
                    Console.WriteLine("O número é ímpar");

                Console.ReadLine();
            }
        }
    }
}
