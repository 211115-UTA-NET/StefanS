namespace RockPaperScissorsApp.App
{    public class Outcome : Game
    {
        
        string[] Hands = {"rock","paper","scissors"};
        int r;
        bool win = false;

        public string Calculate(string hand)
        {
            Random R = new Random();
            r = R.Next(Hands.Length);
            String OpponentsHand = Hands[r];

            switch(hand)
            {
                //Losses
                case "rock" when OpponentsHand == "paper":
                    return "loss";
                    break;
                case "paper" when OpponentsHand == "scissors":
                    return "loss";
                    break;
                case "scissors" when OpponentsHand == "rock":
                    return "loss";
                    break;
                //Wins
                case "rock" when OpponentsHand == "scissors":
                    return "win";
                    break;
                case "paper" when OpponentsHand == "paper":
                    return "win";
                    break;
                case "scissors" when OpponentsHand == "rock":
                    return "win";
                    break;
                //Tie
                default:
                    return "tie";
                    break;
            }
        }
    }
}