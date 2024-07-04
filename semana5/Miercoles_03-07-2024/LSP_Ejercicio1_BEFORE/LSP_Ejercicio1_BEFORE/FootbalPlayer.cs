using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Ejercicio1_BEFORE
{
    public class FootbalPlayer : Player
    {
        public string GetMarketValue(PlayerCategoria category)
        {
            string marketValue = "";
            switch (category)
            {
                case PlayerCategoria.Amateur:
                    marketValue = "100";
                    break;
                case PlayerCategoria.Professional:
                    marketValue = "1000";
                    break;
            }
            return marketValue;
        }
    }
}
