using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 18;
            int nPessoas = 2;
            bool acompanhado = nPessoas >= 2;

            string mensagemAdicional;
            if (acompanhado)
            {
                mensagemAdicional = "Joao esta acompanhado.";
            }
            else
                mensagemAdicional = "Joao nao esta acompanhado";

            if ( idade >= 18 || acompanhado)
            {
                Console.WriteLine("Pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Nao pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            Console.ReadLine();
        }
    }
}
