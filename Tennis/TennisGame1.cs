namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private int _mScore1 = 0;
        private int _mScore2 = 0;
        private readonly string _player1Name;
        private readonly string _player2Name;

        public TennisGame1(string player1Name, string player2Name)
        {
            this._player1Name = player1Name;
            this._player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                _mScore1 += 1;
            else
                _mScore2 += 1;
        }

        public string GetScore()
        {
            string score = "";
            var tempScore = 0;
            if (_mScore1 == _mScore2)
            {
                score = ToStringScore(score);
            }
            else if (_mScore1 >= 4 || _mScore2 >= 4)
            {
                var minusResult = _mScore1 - _mScore2;
                if (minusResult == 1) score = "Advantage "+ _player1Name;
                else if (minusResult == -1) score = "Advantage "+_player2Name;
                else if (minusResult >= 2) score = "Win for "+ _player1Name;
                else score = "Win for "+ _player2Name;
            }
            else
            {
                for (var i = 1; i < 3; i++)
                {
                    if (i == 1) tempScore = _mScore1;
                    else { score += "-"; tempScore = _mScore2; }
                    switch (tempScore)
                    {
                        case 0:
                            score += "Love";
                            break;
                        case 1:
                            score += "Fifteen";
                            break;
                        case 2:
                            score += "Thirty";
                            break;
                        case 3:
                            score += "Forty";
                            break;
                    }
                }
            }
            return score;
        }

        private string ToStringScore(string score)
        {
            var retArray = new[] {"Love-All", "Fifteen-All", "Thirty-All"};
            if(_mScore1<=2) return retArray[_mScore1];
            return "Deuce";
        }
    }
}

