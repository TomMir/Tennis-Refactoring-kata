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

    }
}

