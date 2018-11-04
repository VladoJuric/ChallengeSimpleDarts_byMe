using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeSimpleDarts_byMe
{
    public class Game
    {
        private Player _player1;
        private Player _player2;

        private Random _random;
        public Game(string player1Name, string player2Name, int gameType)
        {
            _player1 = new Player();
            _player1.Name = player1Name;
            _player1.Score = gameType;

            _player2 = new Player();
            _player2.Name = player2Name;
            _player2.Score = gameType;

            _random = new Random();
        }

        public string Play()
        {
            string round = "";

            while (_player1.Score > 0 || _player2.Score > 0)
            {
                round += playRound(_player1);
                round += playRound(_player2);
            }

            return round += displayResults();
        }

        private string displayResults()
        {
            string result = String.Format($"{_player1.Name} Extra points: {_player1.Score * -1}<br/>{_player2.Name} Extra points: {_player2.Score * -1}");

            return result += "<br/><br/>Winner: " + (_player1.Score < _player2.Score ? _player1.Name : _player2.Name);
        }

        private string playRound(Player player)
        {
            int oldScore = player.Score;
            int newScore;

            for (int i = 0; i < 3; i++)
            {
                Dart dart = new Dart(_random);
                dart.Throw();
                Score.ScoreDart(player, dart);
            }

            newScore = player.Score;

            if (player.Score < 0) newScore = 0;

            string result = String.Format($"{player.Name} 3 x Hits: {oldScore-player.Score} points, Total Score: {newScore}<br/>");
            return result;
        }
    }
}