namespace OOPDogRace
{
    class Bet : Guy
    {
        private double BetAmount;
        private int DogNumber;
        public string BetMessage { get; set; }
        public int maxBet;
        public int BetReturn;

        public double bet_amount
        {
            get { return BetAmount; }
            set { BetAmount = value; }
        }

        public int dog_number
        {
            get { return DogNumber; }
            set { DogNumber = value; }
        }

        public void betMade(string playername, int dognumber, int betvalue)        //making message for the text boxes
        {
            BetMessage = playername + " bet $" + betvalue + " on dog number: " + dognumber;
        }

        public int FindMaxBet(int balance) //finding the max bet dpending on which player is betting
        {
            if (balance >= 50)
            {
                maxBet = 50;
            }
            else
            {
                maxBet = balance;
            }


            return maxBet;
        }

        public void betReturns(int betvalue)   //calculating the amount the player won
        {
            BetReturn = betvalue * 2;
        }
    }
}
