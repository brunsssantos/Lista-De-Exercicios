namespace ListaDeExercicios.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
            Console.WriteLine("Informe a nota da primeira prova: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o peso da primeira prova: ");
            double p1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota da segunda prova: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o peso da segunda prova: ");
            double p2 = Convert.ToDouble(Console.ReadLine());

            double mediaPonderada = ((n1 * p1) + (n2 * p2)) / (p1 + p2);

            Console.WriteLine($"A média ponderada das duas provas é: {mediaPonderada}");

            Console.ReadLine();


        }
    }
}
