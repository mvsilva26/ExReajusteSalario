using System;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double newsal = 0;

            Console.WriteLine("Digite o salário da pessoa: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            if(salario <= 0)
            {
                Console.WriteLine("Erro, tente novamente");
            }
            else
            {
                if ((salario > 0) && (salario <= 200))
                {
                    Console.WriteLine("Salário sem reajuste");
                }
                else if ((salario > 200) && (salario <= 400))
                {
                    Console.WriteLine("Salário com 20% de aumento");
                    newsal = salario + (salario * 20) / 100;
                    Console.WriteLine("O novo salário é de: R${0}", newsal);
                }
                else if ((salario > 400) && (salario <= 600))
                {
                    Console.WriteLine("Salário com 30% de aumento");
                    newsal = salario + (salario * 30) / 100;
                    Console.WriteLine("O novo salário é de: R${0}", newsal);
                }
                else
                {
                    Console.WriteLine("Salário com 40% de aumento");
                    newsal = salario + (salario * 40) / 100;
                    Console.WriteLine("O novo salário é de: R${0}", newsal);
                }

            }         
            Console.ReadLine();

        }
    }
}
