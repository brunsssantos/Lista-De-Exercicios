namespace ListaDeExercicios.Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.
             
            Console.WriteLine("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1;
            bool primeiro = true;

            Console.WriteLine($"Sequência de Fibonacci: ");

            while ( a <= numero)
            {
                if (primeiro)
                {
                    Console.Write(a);
                    primeiro = false;
                }
                else
                {
                    Console.Write($", {a}");
                }

                int temp = a + b;
                a = b;
                b = temp;

            }

            Console.ReadLine();
        }
    }
}
