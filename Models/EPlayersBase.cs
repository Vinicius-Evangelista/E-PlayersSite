using System.Collections.Generic;
using System.IO;

namespace EplayersMVC.Models
{
    public class EPlayersBase
    {
        public void CriarPastaEArquivo(string _caminho)
        {

            string pasta = _caminho.Split("/")[0];
            // dividir o arquivo em dois e pegar o que está na primeira posição do array.

            string arquivo = _caminho.Split("/")[1];
            // dividir o arquivo em dois e pegar o que está na segunda posição do array.
            // A existência dessa variável é opcional, por isso que ela não é usada.

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
                // criar a pasta se ela não existir.
            }

            if (!File.Exists(_caminho))
            {
                File.Create(_caminho).Close();
                // criar o arquivo se ele não existir e fechar depois.
            }


        }
        public List<string> LerTodasAsLinhasCSV(string _caminho)
        {
            // É necessário que a lista seja uma lista de string porque será retornado uma lista de strings

            List<string> linhas = new List<string>();
            // instância que será retornada com todos os outros dados

            using (StreamReader file = new StreamReader(_caminho))
            {
                //  File é uma instância que abre o arquivo e lê

                string linha;
                // variável temporária

                while ((linha = file.ReadLine()) != null)
                {
                    // ler o que está em file
                    // se for diferente de nada
                    linhas.Add(linha);

                    // adicione na lista linhas
                }
            }

            return linhas;
        }

        public void ReescreverCSV(string _caminho, List<string> linhas)
        {
            // ele precisas receber o arquivo que será lido
            // ele também precisa receber a lista que contém os arquivos que serão reescritos

            using (StreamWriter output = new StreamWriter(_caminho))
            {
                // output está escrevendo um novo arquivo

                // abrir e ler o arquivo _caminho

                foreach (var item in linhas)
                {
                    // vai reescrever cada linha que estiver em linhas
                    output.Write(item + "\n");
                }

            }
        }
    }
}