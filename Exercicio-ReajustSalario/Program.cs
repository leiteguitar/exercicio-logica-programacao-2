using System;

namespace Exercicio_ReajustSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Ajuste Salarial");

            string salario;
            string ajuste;

            Console.WriteLine("Digite o Salário: ");
            salario = Console.ReadLine();
            double pay = Convert.ToDouble(salario);

            Console.WriteLine("Digite o percentual de ajuste: ");
            ajuste = Console.ReadLine();
            double percent = Convert.ToDouble(ajuste);

            percent = percent / 100;

            double calculo = pay * percent;

            double salarioFinal = calculo + pay;

            Console.WriteLine("O salário com reajuste é de: " + salarioFinal);

            //double valor = 178.00; // valor original
            //double percentual = 15.0 / 100.0; // 15%
            //double valor_final = valor + (percentual * valor);
        }
    }
}
