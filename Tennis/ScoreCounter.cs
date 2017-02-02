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
            return new EqualizeCalc(new MoreThanFourCalc(new OtherCasesCalc(null), _player1Name, _player2Name)).Calculate(_mScore1,_mScore2);

            //string score = "";
            //if (_mScore1 == _mScore2)
            //{
            //    score = ToStringScore();
            //}
            //else if (_mScore1 >= 4 || _mScore2 >= 4)
            //{
            //    score = StringAdvantageScore();
            //}
            //else
            //{
            //    score = StringScoreOther(score);
            //}
            //return score;
        }

        //private string StringScoreOther(string score)
        //{

        //}

        //private string StringAdvantageScore()
        //{

        //}

    }
}
