using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********
            // *********
            // **********

            int linha = 0;

            while (linha < 10)
            {
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    Console.Write('*');
                    if (coluna >= linha)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                linha++;
            }
            Console.ReadLine();
        }
    }
}
