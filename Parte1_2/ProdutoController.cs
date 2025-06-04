using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Parte1_2
{
    internal class ProdutoController : BaseController
    {
        //essa classe representa o controlador responsavel pelas acoes da entidade Produto
       
        //questao 1.2
        public override List<string> AcoesProduto
        {
            get
            {
                return new List<string> { "Pesquisar", "Editar", "Salvar", "Excluir" };
            }
        }

        static void Main(string[] args)
        {

            //questao 1.2
            var controller = new ProdutoController();

            Console.WriteLine("Ações disponíveis:");
            foreach (var acao in controller.AcoesProduto)
            {
                Console.WriteLine($"- {acao}");
            }
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

