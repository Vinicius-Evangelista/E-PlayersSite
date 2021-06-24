using System.Collections.Generic;
using EplayersMVC.Models;

namespace EplayersMVC.Interfaces
{
    public interface IJogador
    {
        void Criar (Jogador jogador);

        List<Jogador> Lertodas();

        void Alterar (Jogador jogador);

        void Deletar (int id);
    }
}