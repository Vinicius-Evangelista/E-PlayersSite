using EplayersMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace EplayersMVC.Controllers
{

    [Route("Equipe")]
    public class EquipeController : Controller
    {
        // controler é uma classe nativa do mvc
        // todo método do controller precisa ter um retorno,e sempre retorna para a view para retornar a informação de uma forma visual.

        Equipe equipeModel = new Equipe();
        // instância criada para quando precisar listar os itens no próprio navegador

        // endereço que fica na url do navegador
        // serve para definir qual controlador ele vai acessar

        [Route("Listar")]
        public IActionResult Index()
        {

            // método padrão do controller que deve ter em tode projeto e ele retorna para a página principal, IAction... é o tipo do méotodo
            // É uma ação com resultado que só retorna view

            ViewBag.Equipes = equipeModel.LerTodas();
            // ViewBag é um espaço que será salvo um valor para ser acessado pela view
            return View();
        }


        [Route("Cadastrar")]

        public IActionResult Cadastrar(IFormCollection form)
        {

            // Iformcollection é um parâmetro que recebe formulários 

            Equipe novaEquipe = new Equipe();
            // esse objeto está sendo criado para receber informações

            novaEquipe.IdEquipe = Int32.Parse(form["IdEquipe"]);
            novaEquipe.Nome = form["Nome"];
            // novaEquipe.Imagem = form["Imagem"];

            //Upload Inicial

            if (form.Files.Count > 0)
            {
                // Vai contar os arquivos em file e vai passar para um array a quantidade.

                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");
                // aqui está sendo usado GetCurrent... Porque é necessaário pegar a raiz da pasta toda.

                // combine é utilizado quando se é necessário usar o nome da pasta raiz.

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);
                // Path.Combine pega 4 strings e transforma em um caminho
                // Essa estrutura pega toda estrutura da pasta até a estrutura do arquivo.

                // quando o usuário passa um arquivo chega um ponto que o arquivo não consegui chegar ao sistema e então é necessário copiá-lo.

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    // File streamserve para criar um novo arquivo

                    // Esse using está sendo colocad para copiar o file.

                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;
                // aqui só é pego o nome da imagem pq o arquivo já estará salvo na pasta.

            }
            else
            {
                novaEquipe.Imagem = "semimagem.png";
            }




            // Upload Final 

            equipeModel.Criar(novaEquipe);
            // Estamos adicionando o que está na instância de novaEquipe para EquipeModel, para que seja exibido na View

            ViewBag.Equipes = equipeModel.LerTodas();
            // ele vai ler tudo e atualizar 
            // quando

            return LocalRedirect("~/Equipe/Listar");
            // estamos retornando para á própria página, '~' serve para colcocar o caminho raíz do projeto e não es
        }

        [Route("Excluir/{id}")]

        public IActionResult Excluir(int id)
        {

            equipeModel.Deletar(id);
            ViewBag.Equipes = equipeModel.LerTodas();
            //ViewBag para atualizar a pagina com o método.

            return LocalRedirect("~/Equipe/Listar");


        }

        // para esse método pegar o id precisamos criar uma rota.

    }
}
// a sitaxe deve ser assim porque o dado está vindo do formulário, e está escrito 'form' porque foi o nome que eu coloquei lá em cima
// Dentro das aspas colocamos o name dos inputs