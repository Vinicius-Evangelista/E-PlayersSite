using System.Collections.Generic;
using EplayersMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EplayersMVC.Controllers
{
    [Route("Login")]
    public class LoginController : Controller
    {
        [TempData]
        // dado temporário, recurso do navegador, espaço temporário novamente
        public string Mensagem { get; set; }

        Jogador jogadorModel = new Jogador();

        public IActionResult Index(){
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form){

            List<string> JogadorCSV = jogadorModel.LerTodasAsLinhasCSV("Database/jogador.csv");
            // passando tudo o que está no arquivo para a lista

            var logado = JogadorCSV.Find(x => x.Split(";")[2] == form["Email"] && x.Split(";")[3] == form["Senha"]);
            // se ele encontrar, vai armazenar na variável logado, se não ele não vai receber nenhum valor.


            if (logado != null)
            {
                HttpContext.Session.SetString("_UserName", logado.Split(";")[1]);
                // salvar um item da sessão.
                return LocalRedirect("~/");
            }

            // se for diferente de nulo, conclui a aquisição e volta para a página inicial. 
            
            Mensagem = "Dados incorretos, ou você ainda não está cadastrado !";
            return LocalRedirect("~/Login");

        }

        [Route("Logout")]
        
        public IActionResult Logout(){
            HttpContext.Session.Remove("_UserName");

            return LocalRedirect ("~/");
        }
    }
}