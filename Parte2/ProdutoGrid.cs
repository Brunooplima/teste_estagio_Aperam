using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Parte2
{
    public class ProdutoGrid
    {
        //questao 1.1  
        public string CodigoProduto { get; set; }
        public string DescricaoProduto { get; set; }

        //questao 1.2  
        public List<ProdutoGrid> ListarProdutosExemplo(int grupo, int subgrupo)
        {
            List<ProdutoGrid> produtos = new List<ProdutoGrid>
        {
            new ProdutoGrid { CodigoProduto = "23vs4", DescricaoProduto = "Produto 1 - Grupo " + grupo + ", Subgrupo " + subgrupo },
            new ProdutoGrid { CodigoProduto = "534b4b", DescricaoProduto = "Produto 2 - Grupo " + grupo + ", Subgrupo " + subgrupo },
            new ProdutoGrid { CodigoProduto = "2s3423f23", DescricaoProduto = "Produto 3 - Grupo " + grupo + ", Subgrupo " + subgrupo },
            new ProdutoGrid { CodigoProduto = "6sd5", DescricaoProduto = "Produto 4 - Grupo " + grupo + ", Subgrupo " + subgrupo },
            new ProdutoGrid { CodigoProduto = "45e645we7", DescricaoProduto = "Produto 5 - Grupo " + grupo + ", Subgrupo " + subgrupo },
            new ProdutoGrid { CodigoProduto = "34vs54", DescricaoProduto = "Produto 6 - Grupo " + grupo + ", Subgrupo " + subgrupo },
            new ProdutoGrid { CodigoProduto = "7we745", DescricaoProduto = "Produto 7 - Grupo " + grupo + ", Subgrupo " + subgrupo },
            new ProdutoGrid { CodigoProduto = "345gs", DescricaoProduto = "Produto 8 - Grupo " + grupo + ", Subgrupo " + subgrupo },
            new ProdutoGrid { CodigoProduto = "3sdf6457", DescricaoProduto = "Produto 9 - Grupo " + grupo + ", Subgrupo " + subgrupo },
            new ProdutoGrid { CodigoProduto = "65e4f3", DescricaoProduto = "Produto 10 - Grupo " + grupo + ", Subgrupo " + subgrupo }
        };

            return produtos;
        }

        static void Main(string[] args)
        {
            ProdutoGrid produtoGrid = new ProdutoGrid();
            var lista = produtoGrid.ListarProdutosExemplo(4, 12);

            foreach (var produto in lista)
            {
                Console.WriteLine($"Código: {produto.CodigoProduto}, Descrição: {produto.DescricaoProduto}");
            }
            Console.ReadLine();
        }
    }
}
