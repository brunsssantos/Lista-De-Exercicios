namespace ListaDeExercicios.Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu resultado.
             a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
             b. Pesquise sobre “fatorial”
             */

            Console.WriteLine("Digite um número: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int resultado = 1;

            Console.Write($"{A}! = ");

            for (int i = A; i > 0; i--)
            {
                Console.Write(i);
                if (i > 1)
                    Console.Write(" x ");
                resultado *= i;
            }

            if (A == 0)
                Console.Write("1");

            Console.WriteLine($" = {resultado}");
            Console.ReadLine();
        }
    }
}
