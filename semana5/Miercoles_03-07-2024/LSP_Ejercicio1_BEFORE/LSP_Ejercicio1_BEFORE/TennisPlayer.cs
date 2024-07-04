using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Ejercicio1_BEFORE
{
    public class TennisPlayer : Player
    {
        public override void AssignTeam(Team team)
        {
            throw new NotImplementedException("Soy un jugador de tennis, y no necesito un equipo para jugar");
        }
    }
}
