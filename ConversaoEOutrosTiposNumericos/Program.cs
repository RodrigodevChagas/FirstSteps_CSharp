using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 1200.50;
            
            // O INT é uma variavel que suporta valores ate 32 bits.
            int salarioEmInteiro = (int)salario;
            Console.WriteLine("Inteiro: " + salarioEmInteiro);

            // O long é variavel de 64 bits.
            long idadeDoUniverso = 1300000000;
            Console.WriteLine("Long: " + idadeDoUniverso);
            
            // O short é uma variavel que suporta valores ate 16 bits.
            short quantidadeProdutos = 15000;
            Console.WriteLine("Short: " + quantidadeProdutos);
            
            // Float aguenta tanto quanto o double, porém, o double é mais preciso.
            float altura = 1.80f;
            Console.WriteLine("Float: " + altura);

            Console.ReadLine();
        }
    }
}
