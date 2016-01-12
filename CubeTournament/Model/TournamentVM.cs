using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeTournament.Model
{
    public class TournamentVM
    {
        public TournamentVM(List<GamerVM> gamers) 
        {
            Gamers = gamers;
        }

        public List<GamerVM> Gamers
        {
            get;
            set;
        }

        public static void SortGamersByPoint(List<GamerVM> gamers) 
        {
            gamers.Sort(Comparison)
        }
    }
}
