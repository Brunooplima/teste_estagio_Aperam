using Parte1_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Parte1_3
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

        //questoa 1.3
        public override object InformacoesProduto
        {
            get
            {
                return new
                {
                    NomeTela = "CADASTRO_PRODUTO",
                    CodigoIdentificador = "PRD001"
                };
            }
        }

        static void Main(string[] args)
        {

            //questao 1.3
            var controller = new ProdutoController();
            var info = controller.InformacoesProduto;

            Console.WriteLine("Informações do Produto:");
            Console.WriteLine($"Nome da Tela: {info.GetType().GetProperty("NomeTela")?.GetValue(info)}");
            Console.WriteLine($"Código de identificador do Módulo: {info.GetType().GetProperty("CodigoModulo")?.GetValue(info)}");

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

