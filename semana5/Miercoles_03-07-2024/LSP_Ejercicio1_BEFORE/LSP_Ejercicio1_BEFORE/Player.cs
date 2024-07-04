using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Ejercicio1_BEFORE
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Team Team { get; set; }
        public PlayerCategoria Category { get; set; }

        public string GetTeam() => Team.Name;

        public virtual void AssignTeam(Team team)
        {
            Team = team;
        }

        public virtual void SetCategory(PlayerCategoria category)
        {
            Category = category;
        }
    }
}
