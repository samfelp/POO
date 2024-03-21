using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;

namespace Atv1_POO
{
    public class Produto
    {
        //Código do produto, descrição (o nome do produto), unidade (LT, CX, KG, UN, MT), preço, quantidade em estoque.
        private string id;
        private string descricao;
        private string unidade;
        private double preco;
        private double quantidade;

       public string getId() 
        {
            return id;
        }

        public string getDescricao()
        {
            return descricao;
        }
        public string getUnidade() 
        {
            return unidade;
        }
        public double getPreco()
        {
            return preco;
        }
        public double getQuantidade()
        {
            return quantidade;
        }


        public void setId(string id)
        {
            this.id = id;
        }
        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public void setUnidade(string unidade)
        {
            if(unidade == "L" || unidade == "CX" || unidade == "KG" || unidade == "UN" || unidade == "MT" || unidade == "l" || unidade == "cx" || unidade == "kg" || unidade == "un" || unidade == "mt")
            {
                this.unidade = unidade;
            }
            else
            {
                Console.WriteLine("essa unidade não ta certa não");
            }
        }

        public void setPreco(double preco)
        {   
            if(preco > 0)
            {
                this.preco = preco;

            }
            else
            {
                Console.WriteLine("a gente não faz caridade!! quero meus lucros $$$$");
            }
                
        }

        public void setQuantidade(double quantidade)
        {
            this.quantidade = quantidade;
        }
    }
}
