using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace Parte1_1
{
    public class BaseController 
    {
        //classe base que está simluando um controlador MVC
        
    }


    public class ProdutoService
    {
        //aqui realiza a camada de logica de negocio
        public void Processar() => Console.WriteLine("Processando produto...");

    }

    public class ProdutoViewModel
    {
        public string Nome { get; set; }
        public int Id { get; set; }
    }

    public static class UsuarioLogado
    {
        public static string Chave { get; set; } = "usuario123"; // Simulando uma chave de usuário logado
    }

}
