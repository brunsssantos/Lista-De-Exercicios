namespace ListaDeExercicios.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

            #region input de dados
            Console.WriteLine("Digite o valor de A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            int C = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region processamento e output
            if (A + B > C)
            {
                Console.WriteLine(" A soma de A + B não é menor que C");
            }
            else
                Console.WriteLine("A soma de A + B é menor que C");
            Console.ReadLine();
            #endregion
        }
    }
}
