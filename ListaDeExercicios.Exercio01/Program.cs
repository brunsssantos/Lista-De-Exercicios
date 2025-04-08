namespace ListaDeExercicios.Exercio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criar um projeto para calcular o volume de uma caixa retangular
            //Volume da Caixa: comprimento x largura x altura

            #region input de dados
            Console.WriteLine("Digite o comprimento da caixa: ");
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a largura da caixa: ");
            decimal largura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a altura da caixa: ");
            decimal altura = Convert.ToDecimal(Console.ReadLine());

            #endregion

            #region processamento
            decimal resultado = comprimento * largura * altura;
            #endregion

            #region output
            Console.WriteLine($"O volume da caixa é: {resultado}");
            Console.ReadLine();
            #endregion
        }
    }
}
