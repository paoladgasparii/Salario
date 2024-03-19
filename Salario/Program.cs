using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salariobruto = 0;
            double salarioliquido = 0;
            double descontoir = 0;
            double ir = 0;

            Console.WriteLine("Insira a forma de contratação (A)ssalariado (C)omissionado (H)orista: ");
            string contratacao = Console.ReadLine();

            switch (contratacao)
            {
                case "A":
                    Console.WriteLine("Digite o valor do salário bruto: ");
                    double salarioa = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor do desconto: ");
                    double desc = double.Parse(Console.ReadLine());

                    salariobruto = salarioa - desc;
                    break;

                case "C":
                    Console.WriteLine("Digite a quantidade de peças produzidas: ");
                    int pecas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor recebido por peça: ");
                    double valorpecas = double.Parse(Console.ReadLine());

                    salariobruto = pecas * valorpecas;
                    break;

                case "H":
                    Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
                    int hora = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor recebido por hora: ");
                    double valorhora = double.Parse(Console.ReadLine());

                    salariobruto = hora * valorhora;
                    break;

            }

            if (salariobruto <= 2000)
            {
                descontoir = salariobruto * 0.075;
                salarioliquido = salariobruto - descontoir;
            }

            else if (salariobruto <= 4000)
            {
                descontoir = salariobruto * 0.12;
                salarioliquido = salariobruto - descontoir;
            }

            else if (salariobruto > 4000)
            {
                descontoir = salariobruto * 0.15;
                salarioliquido = salariobruto - descontoir;
            }

            Console.WriteLine("O salário líquido do funcionário é: " + salarioliquido);

            Console.ReadKey();
        }
    }
}
