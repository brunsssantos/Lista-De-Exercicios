namespace ListaDeExercicios.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base
             * e o total de vendas. 
             * A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.
             */
            #region input de dados
            Console.WriteLine("Informe o salário base: ");
            double salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o total de vendas: ");
            double totalVendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o percentual de comissão (%): ");
            double percentualComissao = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento
            double comissao = (percentualComissao / 100) * totalVendas;

            double salarioTotal = salarioBase + comissao;
            #endregion

            #region output
            Console.WriteLine($"O salário total é: R${salarioTotal:F2}");

            Console.ReadLine();
            #endregion
        }
    }
}
