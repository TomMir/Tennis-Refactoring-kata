namespace Tennis
{
    public abstract class ScoreCalculation
    {
        internal ScoreCalculation _successor;

        protected ScoreCalculation(ScoreCalculation successor)
        {
            this._successor = successor;
        }

        public abstract string Calculate(int mScore1, int mScore2);
    }
}
