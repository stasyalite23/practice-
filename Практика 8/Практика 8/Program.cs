using System;

namespace Практика_8
{
    class FootballPlayer
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public FootballPlayer(string name, int number)
        {
            Name = name;
            Number = number;
        }
        public override string ToString() => $"{Number}:{Name}";
    }
    class FootballTeam
    {
        private readonly FootballPlayer[] _players = new FootballPlayer[11];
        public FootballTeam() { }
        public FootballTeam(FootballPlayer[] players)
        {
            if (players.Length != 11)
                throw new ArgumentOutOfRangeException("Игроков должно быть 11 человек");
            _players = players;
        }
        public FootballPlayer this[int index]
        {
            get => CheckIfIndexCorrect(index) ? _players[index] : null;
            set
            {
                if (!CheckIfIndexCorrect(index))
                    return;
                _players[index] = value;
            }
        }
        private bool CheckIfIndexCorrect (int index) => index >= 0 && index <= 10;
    }
        class Program
        {
            static void Main(string[] args)
            {
                FootballTeam team = new FootballTeam();
                team[8] = new FootballPlayer("Arasakov", 25);
                Console.WriteLine(team[8]);
                Console.WriteLine(team[8] is null);
            }
        }
}

