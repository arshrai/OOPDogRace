using System;

namespace OOPDogRace
{
    class Race
    {
        Random r = new Random();
        public int winningDog;



        public void DogRace()     //gives a random number for who won the race
        {
            winningDog = r.Next(1, 5);
        }
    }
}
