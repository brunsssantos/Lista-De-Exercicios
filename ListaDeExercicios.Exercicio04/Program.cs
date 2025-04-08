namespace ListaDeExercicios.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

            Console.WriteLine("Informe a temperatura em Celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"A temperatura {celsius}°C convertida para Fahrenheit é {fahrenheit}°F ");

            Console.ReadLine();
        }
    }
}
