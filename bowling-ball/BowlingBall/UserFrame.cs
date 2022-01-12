using BowlingBall.Pin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class UserFrame : IUserFrame
    {
        public int frameNo { get; set; }
        public int firstPinScore { get; set; }
        public int secondPinScore { get; set; }

    }
}
