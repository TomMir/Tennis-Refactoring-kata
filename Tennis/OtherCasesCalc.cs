namespace Tennis
{
    public class OtherCasesCalc: ScoreCalculation
    {
        public OtherCasesCalc(ScoreCalculation successor) : base(successor)
        {
        }

        public override string Calculate(int mScore1, int mScore2)
        {
            string score = string.Empty;
            for (var i = 1; i < 3; i++)
            {
                int tempScore;
                if (i == 1) tempScore = mScore1;
                else
                {
                    score += "-";
                    tempScore = mScore2;
                }
                var storeStringArray = new[] { "Love", "Fifteen", "Thirty", "Forty" };
                score += storeStringArray[tempScore];
            }
            return score;
        }
    }
}
