namespace ListaDeExercicios.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de 
             * acordo com a listagem de IMC
             */
            #region input de dados
            Console.WriteLine("Digite seu peso (em kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua altura (metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento
            double imc = peso / (altura * altura);
            #endregion

            #region output
            Console.WriteLine($"Seu IMC é: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Condição: Abaixo do peso");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Condição: Peso normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Condição: Acima do peso");
            }
            else
                Console.WriteLine("Condição: Obeso");

            Console.ReadLine();
            #endregion
        }
    }
}
