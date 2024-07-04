using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Ejercicio1_AFTER
{
    public class FootbalPlayer : Player, IPlayerTeam
    {
        public Team Team { get ; set ; }

        public void AssignTeam(Team team)
        {
            Team = team;
        }

        public string GetTeam()
        {
            return Team.Name;
        }

        public string GetMarketValue(PlayerCategory category)
        {
            string marketValue = "";
            switch (category)
            {
                case PlayerCategory.Amateur:
                    marketValue = "100";
                    break;
                case PlayerCategory.Professional:
                    marketValue = "1000";
                    break;
            }
            return marketValue;
        }
    }
}
