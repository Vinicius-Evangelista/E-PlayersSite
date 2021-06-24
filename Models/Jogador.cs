using System;
using System.Collections.Generic;
using System.IO;
using EplayersMVC.Interfaces;
namespace EplayersMVC.Models
{
    public class Jogador : EPlayersBase, IJogador
    {
        public int IdJogador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int IdEquipe { get; set; }

        private const string CAMINHO = "Database/jogador.csv";

        public Jogador()
        {

            CriarPastaEArquivo(CAMINHO);
        }

        public string Preparar(Jogador jogador)
        {

            return $"{jogador.IdJogador};{jogador.Nome};{jogador.Email};{jogador.Senha};{jogador.IdEquipe}";
        }

        public void Criar(Jogador jogador)
        {
            string[] linha = { Preparar(jogador) };

            File.AppendAllLines (CAMINHO, linha);
        }

        public List<Jogador> Lertodas()
        {
           List<Jogador> jogadores = new List<Jogador>();

            string [] linhas = File.ReadAllLines(CAMINHO);

            foreach (var item in linhas)
            {
                string [] linha = item.Split(";");

                Jogador jogador = new Jogador();

                jogador.IdJogador = Int32.Parse(linha[0]);
                jogador.Nome = linha[1];
                jogador.Email = linha[2];
                jogador.Senha = linha[3];
                jogador.IdEquipe = Int32.Parse(linha[4]);

                jogadores.Add(jogador);
            }

            return jogadores;
        }

        public void Alterar(Jogador jogador)
        {
            List<string> linhas = LerTodasAsLinhasCSV(CAMINHO);
            linhas.RemoveAll(x => x.Split(";")[0] == jogador.IdJogador.ToString());
            linhas.Add(Preparar(jogador));

            ReescreverCSV(CAMINHO,linhas);
        }

        public void Deletar(int id)
        {
           List<string> linhas = LerTodasAsLinhasCSV(CAMINHO);
           linhas.RemoveAll(x => x.Split(";")[0] == id.ToString());
           ReescreverCSV(CAMINHO, linhas);
        }
    }
}