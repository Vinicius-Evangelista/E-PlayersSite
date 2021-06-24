using System.Collections.Generic;
using EplayersMVC.Models;

namespace EplayersMVC.Interfaces
{
    public interface IEquipe
    {
        void Criar(Equipe equipe);

        List<Equipe> LerTodas();

        void Alterar(Equipe equipe);

        void Deletar (int id);        
         
    }
}