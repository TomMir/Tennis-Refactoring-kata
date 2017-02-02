using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    public class ScoreCounter : IScoreCounter
    {
        private int _mScore1;
        private int _mScore2;
        private readonly string _player1Name;
        private readonly string _player2Name;

        public ScoreCounter(string player1Name, string player2Name)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
        }

        public void UpdateScore1()
        {
            _mScore1++;
        }

        public void UpdateScore2()
        {
            _mScore2++;
        }

        public string AsString()
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
                var storeStringArray = new[] { "Love", "Fifteen", "Thirty", "Forty" };
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
            var retArray = new[] { "Love-All", "Fifteen-All", "Thirty-All" };
            return _mScore1 <= 2 ? retArray[_mScore1] : "Deuce";
        }
    }
}
