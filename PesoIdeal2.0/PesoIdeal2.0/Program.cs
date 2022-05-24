using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            double altura, peso, pesoIdeal;

            Console.WriteLine("=================== SEU PESO IDEAL ===================");
            Console.WriteLine("SEJA BEM VINDO AO SEU PESO IDEAL \nME DIGA SEU NOME, SUA IDADE, E SUA ALTURA A SEGUIR...");
            Console.WriteLine("NOME: ");
            nome = Console.ReadLine();
            Console.WriteLine("IDADE: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("ALTURA: ");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("PESO ATUAL: ");
            peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            pesoIdeal = (72.7 * altura) - 58;

            Console.WriteLine("DADOS FORNECIDOS:\n- NOME: {0} \n- IDADE: {1} \n- ALTURA: {2} \n- PESO ATUAL: {3}", nome, idade, altura.ToString("F2"), peso.ToString("F2"));

            if (peso > pesoIdeal)
            {
                Console.WriteLine("{0} DE ACORDO COM OS DADOS FORNECIDOS, VOCÊ ESTA ACIMA DO SEU PESO IDEAL\nE ISSO É PREJUDICIAL A SUA SAÚDE, VOCÊ PRECISA CHEGAR AO PESO {1:F2}kg PARA SE MANTER EM FORMA !!", nome, pesoIdeal);
            }
            else if (peso <= pesoIdeal)
            {
                Console.WriteLine("PARABENS {0} SEU PESO ESTÁ DE ACORDO COM O SEU PESO IDEAL\n- PESO ATUAL: {1:F2}kg\n- PESO IDEAL: {2:F2}kg", nome, peso, pesoIdeal);
            }

            Console.ReadLine();
        }
    }
}