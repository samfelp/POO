using Atv1_POO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;
using static System.Console;

public class program
{
    static void Main(string[] args)
    {
        List<Produto> listaProdutos = new List<Produto>();
        int op = 0;
        do
        {
            Clear();
            WriteLine("mozao, vc quer oq?");
            WriteLine("1 - cadastrar produto");
            WriteLine("2 - consultar todos os produtos");
            WriteLine("3 - apagar algum produto da lista");
            WriteLine("4 - sair");
            op = ToInt32(ReadLine());
            switch (op)
            {
                case 1:
                    do
                        {
                            Produto prod = new Produto();
                            WriteLine("insire o codigo de barras");
                            prod.setDescricao(ReadLine());
                            WriteLine("insire a descrição");
                            prod.setDescricao(ReadLine());
                            WriteLine("insira a unidade");
                            prod.setUnidade(ReadLine());
                            WriteLine("insira o preço");
                            prod.setPreco(ToDouble(ReadLine()));
                            WriteLine("insira a quantidade");
                            prod.setQuantidade(ToDouble(ReadLine()));
                            listaProdutos.Add(prod);

                            Clear();
                            WriteLine("repeteco mor?");
                            WriteLine("1 - simmm");
                            WriteLine("2 - nai");
                            op = ToInt32(ReadLine());
                        }
                    while (op == 1);
                    break;

                case 2:
                    foreach(Produto prodi in listaProdutos)
                    {
                        WriteLine("----------------------------------");
                        WriteLine("Descrição: "+ prodi.getDescricao());
                        WriteLine("Unidade: "+ prodi.getUnidade());
                        WriteLine("Preço: "+ prodi.getPreco());
                        WriteLine("Quantidade: "+ prodi.getQuantidade());
                        WriteLine("----------------------------------");
                    }
                    Console.ReadKey();


                    break;

                case 3:
                    WriteLine("digite o codigo de barras do produto que sera apagado");
                    string cod = ReadLine();
                    Produto pExcluir = listaProdutos.FirstOrDefault(x => x.getId() == cod);
                    listaProdutos.Remove(pExcluir);
                    break;

                default:

                    break;
            }

        }
        while (op != 3);

    }
}