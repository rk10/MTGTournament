using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeTournament.Model
{
    public class GamePairVM  
    {
        Game
    }

    public class StageVM
    {
        public StageVM(List<GamerVM> gamers) 
        {
            Pairs = new List<GamePairVM>();
            CreatePairsSet(gamers);
        }

        public List<GamePairVM> Pairs
        {
            get;
            set;
        }

        public void CreatePairsSet(List<GamerVM> gamers) 
        {
            Pairs.Clear();

            if() 
            {

            }
        }
    }
}
