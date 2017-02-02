namespace Tennis
{
    public interface IScoreCounter
    {
        void UpdateScore1();
        void UpdateScore2();
        string AsString();
    }
}