namespace ListaDeExercicios.Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            for (numero = 1; numero < 101; numero++)
            {

                if (numero % 3 == 0 && numero % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (numero % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else if (numero % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                    Console.WriteLine(numero);
            }
            Console.ReadLine();
        }
    }
}
