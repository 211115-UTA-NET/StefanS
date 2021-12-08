namespace RockPaperScissorsApp.App
{
    public class Game
    {
        int gamesWon = 0;
        int totalGames = 0;
        List<string> gameOutcomes = new List<string>();
        public string Summary
        {
            get
            {
                return $"You've won {gamesWon} out of {totalGames} games";
            }
        }

        public void PlayRound()
        {
            totalGames++;
            string hand;

            Console.WriteLine("Chose your hand (Rock,Paper,Scissors)");
            hand = Console.ReadLine();
            hand = hand.ToLower();
            var O = new Outcome();

            switch (O.Calculate(hand))
            {
                case "tie":
                    gameOutcomes.Add("tie");
                    Console.WriteLine("You tied");
                    break;
                case "win":
                    gameOutcomes.Add("win");
                    Console.WriteLine("You win!");
                    gamesWon++;
                    break;
                case "loss":
                    gameOutcomes.Add("loss");
                    Console.WriteLine("You lose");
                    break;
            }
        }
    }
}
