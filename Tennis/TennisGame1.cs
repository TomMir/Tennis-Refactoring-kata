namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private int _mScore1 = 0;
        private int _mScore2 = 0;
        private readonly string _player1Name;
        private ScoreCounter _scoreCounter;
        private string _player2Name;

        public TennisGame1(string player1Name, string player2Name)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
            _scoreCounter =new ScoreCounter(player1Name,player2Name);
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                _scoreCounter.UpdateScore1();
            else
                _scoreCounter.UpdateScore2();
        }

        public string GetScore()
        {
            return _scoreCounter.AsString();
        }

        private string Score()
        {
            string score = "";
            if (_mScore1 == _mScore2)
            {
                score = ToStringScore();
            }
            else if (_mScore1 >= 4 || _mScore2 >= 4)
            {
                score = StringAdvantageScore();
            }
            else
            {
                score = StringScoreOther(score);
            }
            return score;
        }

        private string StringScoreOther(string score)
        {
            for (var i = 1; i < 3; i++)
            {
                int tempScore;
                if (i == 1) tempScore = _mScore1;
                else
                {
                    score += "-";
                    tempScore = _mScore2;
                }
                var storeStringArray = new[] {"Love", "Fifteen", "Thirty", "Forty"};
                score += storeStringArray[tempScore];
            }
            return score;
        }

        private string StringAdvantageScore()
        {
            string score;
            var minusResult = _mScore1 - _mScore2;
            if (minusResult == 1) score = "Advantage " + _player1Name;
            else if (minusResult == -1) score = "Advantage " + _player2Name;
            else if (minusResult >= 2) score = "Win for " + _player1Name;
            else score = "Win for " + _player2Name;
            return score;
        }

        private string ToStringScore()
        {
            var retArray = new[] {"Love-All", "Fifteen-All", "Thirty-All"};
            return _mScore1<=2 ? retArray[_mScore1] : "Deuce";
        }
    }
}

