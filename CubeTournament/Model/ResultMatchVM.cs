using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeTournament.Model
{
    public class ResultMatchVM
    {
        public bool IsBuy
        {
            get;
            set;
        }

        public GamerVM GamerOne
        {
            get;
            set;
        }

        public GamerVM GamerTwo
        {
            get;
            set;
        }

        public int GamerOnePoint
        {
            get;
            set;
        }

        public int GamerTwoPoint
        {
            get;
            set;
        }

        
    }
}
