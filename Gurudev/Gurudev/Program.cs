using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gurudev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nao precisa criar instânicas para chamar metodos static
            //Veiculo.cilindradas = "";

            //string testeCpf = "087.503.832-80";
            //Validacao.ValidarCPF(testeCpf);

            string testeNiv = "7Av 92XDd4 5x 4d6166";
            Validacao.ValidarNIV(testeNiv);

            Console.ReadKey();
        }
    }
}
