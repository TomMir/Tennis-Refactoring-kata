namespace Tennis
{
    public class MoreThanFourCalc: ScoreCalculation
    {
        private string _player1Name;
        private string _player2Name;

        public MoreThanFourCalc(ScoreCalculation successor, string player1Name, string player2Name) : base(successor)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
        }

        public override string Calculate(int mScore1, int mScore2)
        {
            if (mScore1 < 4 && mScore2 < 4) return this._successor.Calculate(mScore1, mScore2);
            string score;
            var minusResult = mScore1 - mScore2;
            switch (minusResult)
            {
                case 1:
                    score = "Advantage " + _player1Name;
                    break;
                case -1:
                    score = "Advantage " + _player2Name;
                    break;
                default:
                    score = minusResult >= 2 ? "Win for " + _player1Name : "Win for " + _player2Name;
                    break;
            }
            return score;
        }
    }
}
