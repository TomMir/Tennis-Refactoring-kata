namespace Tennis
{
    public class EqualizeCalc:ScoreCalculation
    {
        public EqualizeCalc(ScoreCalculation successor) : base(successor)
        {
        }


        public override string Calculate(int mScore1, int mScore2)
        {
            if (mScore1 != mScore2) return this._successor.Calculate(mScore1, mScore2);
            var retArray = new[] { "Love-All", "Fifteen-All", "Thirty-All" };
            return mScore1 <= 2 ? retArray[mScore1] : "Deuce";
        }
    }
}
