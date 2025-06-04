using Parte1_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Parte1_1
{
    internal class ProdutoController : BaseController
    {
        //essa classe representa o controlador responsavel pelas acoes da entidade Produto

        static void Main(string[] args)
        {
            //questao 1.1
            ProdutoService produtoService = new ProdutoService();
            produtoService.Processar();
            ProdutoController produtoController = new ProdutoController();
            produtoController.Index();
            string resposta = produtoController.Inicializar();
            Console.WriteLine(resposta);
            //espera o usuario pressionar uma tecla para finalizar o programa
            Console.ReadLine();         
        

        }       

        //questao 1.1
        private ProdutoService _produtoService;

        public ProdutoController()
        {
            _produtoService = new ProdutoService();
        }

        public void Index()
        {
            Console.WriteLine("Realizando o carregamento da página inicial do modulo....");
        }

        public string Inicializar()
        {
            try
            {
                ProdutoViewModel produtoView = new ProdutoViewModel
                {
                    Nome = "Produto Exemplo",
                    Id = 1
                };


                //sumulando permissoes e usuario logado
                var resposta = new
                {
                    permissoes = new[] { "Visualizar", "Editar", "Excluir" },
                    usuario = UsuarioLogado.Chave,
                    produto = produtoView,
                };
                return JsonSerializer.Serialize(resposta);
            }
            catch (Exception ex)
            {
                return JsonSerializer.Serialize(new { Mensagem = ex.Message });
            }

        }

    }
}

