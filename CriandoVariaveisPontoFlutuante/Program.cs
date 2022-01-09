using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3. Criando variaveis ponto flutuante.");
            
            double salario;
            salario = 1300.10;
            Console.WriteLine(salario);

            double idade;
            idade = 21.0 / 2;
            Console.WriteLine(idade);

            idade = 23 / 3;
            Console.WriteLine(idade);

            idade = 23.0 / 3;
            Console.WriteLine("Sua idade é " + idade + "!");

            Console.WriteLine("A execução acabou. Aperte enter para sair...");
            Console.ReadLine();
        }
    }
}
