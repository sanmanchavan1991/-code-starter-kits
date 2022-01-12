namespace BowlingBall
{
    public interface IUserFrame
    {
        int firstPinScore { get; set; }
        int frameNo { get; set; }
        int secondPinScore { get; set; }
    }
}