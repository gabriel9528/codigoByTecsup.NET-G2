using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Ejercicio1_AFTER
{
    public interface IPlayerTeam : IPlayer
    {
        Team Team { get; set; }
        string GetTeam();
        void AssignTeam(Team team);
    }
}
