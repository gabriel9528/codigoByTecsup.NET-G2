using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Ejercicio1_AFTER
{
    public class Player : IPlayer
    {
        public string FirstName { get ; set; }
        public string LastName { get; set; }
        public PlayerCategory Category { get; set; }
        public virtual void SetCategory(PlayerCategory category)
        {
            Category = category;
        }
    }
}
