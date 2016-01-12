using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeTournament.Model
{
    public class GamerVM : IComparable<GamerVM>
    {
        public GamerVM() 
        {
            Games = new List<ResultMatchVM>();  
        }

        public string Name
        {
            get;
            set;
        }

        public List<ResultMatchVM> Games
        {
            get;
            set;
        }

        public int PointsCount() 
        {
            int sum = 0;

            foreach(var game in Games) 
            {
                if (game.GamerOnePoint > game.GamerTwoPoint)
                    sum += 3;
                else if (game.GamerOnePoint == game.GamerTwoPoint)
                    sum += 1;
            }

            return sum;
        }

        public int BuyCount() 
        {
            return Games.Count(g => g.IsBuy);
        }

        // 0 - ничья, 1 - победа, -1 - поражение, null - игры не было
        public int? VictoryOverGamer(GamerVM gamer) 
        {
            var game = Games.FirstOrDefault(g => g.GamerTwo == gamer);

            if(game == null) 
            {
                return null;
            }

            return game.GamerOnePoint.CompareTo(game.GamerTwoPoint);  
        }

        public double RatioWinToLose() 
        {
            int winCount = 0;
            int loseCount = 0;

            foreach (var game in Games)
            {
                winCount = game.GamerOnePoint;
                loseCount = game.GamerTwoPoint;
            }

            return ((double)winCount) / ((double)loseCount);
        }


        public int CompareTo(GamerVM other)
        {
            int thPointsCount = this.PointsCount();
            int othPointsCount = other.PointsCount();
            if (thPointsCount != othPointsCount) 
            {
                return thPointsCount > othPointsCount ? 1 : -1; 
            }
            else 
            {
                int thBuyCount = this.BuyCount();
                int othBuyCount = other.BuyCount();
                if (thBuyCount != othBuyCount)
                {
                    return thBuyCount > othBuyCount ? -1 : 1;
                }
                else 
                {
                    if (this.RatioWinToLose() != other.RatioWinToLose())
                    {
                        return this.RatioWinToLose() > other.RatioWinToLose() ? 1 : -1;
                    }
                    else 
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
