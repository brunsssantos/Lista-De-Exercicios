namespace ListaDeExercicios.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular o volume de um Cilindro
            // V =  π. r². h

            #region input de dados
            Console.WriteLine("Digite o raio do cilindro: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura do cilindro: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento
            double volume = Math.PI * Math.Pow(raio,2) * altura;
            #endregion

            #region output
            Console.WriteLine($"O volume do cilindro é: {volume}");
            Console.ReadLine();
            #endregion
        }
    }
}
