namespace ListaDeExercicios.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calcule o consumo de combustível por quilômetro percorrido em uma viagem.

            #region input de dados
            Console.WriteLine("Informe a quilometragem inicial: ");
            double quilometragemInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quilometragem final: ");
            double quilometragemFinal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de combustível consumida durante a viagem (em litros): ");
            double combustivel = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento
            double distanciaPercorrida = quilometragemFinal - quilometragemInicial;
            double consumoPorKm = combustivel / distanciaPercorrida;
            #endregion

            #region output
            Console.WriteLine($"O consumo de combustível por quilômetro percorrido na viagem foi: {consumoPorKm} L/km");
            Console.ReadLine();
            #endregion

        }
    }
}
