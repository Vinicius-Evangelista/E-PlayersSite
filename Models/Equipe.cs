using System;
using System.Collections.Generic;
using System.IO;
using EplayersMVC.Interfaces;


namespace EplayersMVC.Models
{
    public class Equipe : EPlayersBase, IEquipe
    {
        public int IdEquipe { get; set; }
    
        public string Nome { get; set; }
        
        public string Imagem { get; set; }

        private const string CAMINHO = "Database/equipe.csv";


        // CRUD
        // Antes de fazer qualquer outra estapa do CRUD é necessário começar pelo processo de de adiconar (C)

        public Equipe()
        {
            CriarPastaEArquivo(CAMINHO);
        }


        public List<Equipe> LerTodas()
        {
            // o que vem antes do nome do método é apenas a descrição de que tipo será o retorno

            List<Equipe> equipes = new List<Equipe>();

            string[] linhas = File.ReadAllLines(CAMINHO);
            // Lê e salva todas as linhas no CAMINHO e passa para linhas

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                // Ele vai separar cada item da linha e vai colocar em linha

                Equipe equipe = new Equipe();
                // para cada linha que tiver em linhas será instânciado um novo objeto

                equipe.IdEquipe = Int32.Parse(linha[0]);
                equipe.Nome = linha[1];
                equipe.Imagem = linha[2];
                // todos os dados estão armazenados no array linha só que em posição de array 

                equipes.Add(equipe);
                //cada objeto que for criado será adicionado em esquipes
            }

            return equipes;
            // retorna a lista inteira 
        }

        private string Preparar(Equipe equipe)
        {

            return $"{equipe.IdEquipe};{equipe.Nome};{equipe.Imagem}";
            // primeiro conteudo vai ser adicionado, depois disso o método Preparar() vai formatá-lo de uma forma que quando ele for adiconar no Database fica organizado.              
        }

        public void Alterar(Equipe equipe)
        {
            // Para Alterar precisa receber um parâmetro que seja um instância de Equipe

            List<string> linhas = LerTodasAsLinhasCSV(CAMINHO);
            linhas.RemoveAll(x => x.Split(";")[0] == equipe.IdEquipe.ToString());
            // vai pegar as linhas em 'linhas' e vai separar, vai pegar aquele que esta na posição 0 do array
            // e se for igual ao atributo da instância essa linha será removida

            linhas.Add(Preparar(equipe));
            // pegar o que está em equipe, organizar as informações e colocar em linhas

            ReescreverCSV(CAMINHO, linhas);
            // vai reescrever o que estiver em linhas para o arquivo (caminho)
        }

        public void Criar(Equipe equipe)
        {
            string[] linha = { Preparar(equipe) };
            // linha (Array) recebe os dados formatados de Preparar e armazena 

            File.AppendAllLines(CAMINHO, linha);
            // Esse método pede dois argumentos, 1° argumento: onde será salve, 2° o que será salvo;
        }
        public void Deletar(int id)
        {
            List<string> linhas = LerTodasAsLinhasCSV(CAMINHO);
            linhas.RemoveAll(x => x.Split(";")[0] == id.ToString());
            // a equipe deseja será removida

            ReescreverCSV(CAMINHO, linhas);
            // os dados serão reescritos de volta o que está no arquivo CSV
        }
    }


}