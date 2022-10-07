using System;
//create card

namespace card_game


{
    // a card has a value from 1-13 randomized
    // the responsibility of card is to keep track of its currently rolled value
    // and if it is higher or lower than the next one
    public class Card
    {
        public int value = 0;
        public int points = 0;

        public Card()
        {
        }


        // Generates a new card value from 1-13
        public void DrawCard()
        {
            Random random = new Random();
            value = random.Next(1,14);
        }

    }
}