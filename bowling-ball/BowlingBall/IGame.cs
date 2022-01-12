using BowlingBall.Frame;
using System.Collections.Generic;

namespace BowlingBall
{
    public interface IGame
    {
        void Run(int[,] rolls);
    }
}