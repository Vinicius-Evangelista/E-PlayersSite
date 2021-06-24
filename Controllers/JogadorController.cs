using EplayersMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace EplayersMVC.Controllers
{
    [Route("Jogador")]
    public class JogadorController : Controller
    {
        Jogador jogadorModel = new Jogador();

        [Route("Listar")]
        public IActionResult Index()
        {

            ViewBag.Jogadores = jogadorModel.Lertodas();
            return View();

        }

        [Route ("Cadastrar")]
        public IActionResult Cadastrar (IFormCollection form){

            Jogador novoJogador = new Jogador();

            novoJogador.IdJogador = Int32.Parse(form["IdJogador"]);
            novoJogador.Nome = form["Nome"];
            novoJogador.Email = form["Email"];
            novoJogador.Senha = form["Senha"];
            novoJogador.IdEquipe = Int32.Parse(form["IdEquipe"]);

            jogadorModel.Criar(novoJogador);

            ViewBag.Jogadores = jogadorModel.Lertodas();

            return LocalRedirect("~/Jogador/Listar");

        }

        [Route ("Excluir/{id}")]

        public IActionResult Excluir (int id){

            jogadorModel.Deletar(id);
            ViewBag.Jogadores = jogadorModel.Lertodas();

            return LocalRedirect("~/Jogador/Listar");
        }
    }


}