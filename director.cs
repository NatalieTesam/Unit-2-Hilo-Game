namespace card_game
{
    public class Director
    {
        public bool _isPlaying = true;
        public int _yourScore = 300;
        public string _relation = "";
        public Card newCard = new Card();

        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        // The end message
        System.Console.WriteLine("--Game Over--");
        }

        public void GetInputs()
        {
            // Draw the first card and tell the user the value
            Card theCard = new Card();
            theCard.DrawCard();
            // displays the current card's value
            System.Console.WriteLine($"\nThe card is: {theCard.value}");

            // Draw a second card and compare the value and save the relation
            newCard.DrawCard();

            if(newCard.value > theCard.value)
            {
                _relation = "h";
            }
            else if(newCard.value < theCard.value)
            {
                _relation = "l";
            }
            
        }

        public void DoUpdates()
        {
            // Their guess if it is higher or lower (h/l)
            System.Console.WriteLine("Is the next card higher or lower?(h/l):");
            string answer = System.Console.ReadLine();

            //updates the score based on what the relation from the inputs was
            if(answer == _relation) 
            {
                _yourScore = _yourScore + 100;
            }
            else if(answer != _relation)
            {
                _yourScore = _yourScore - 75;
            }
            // displays the next card's value
            System.Console.WriteLine($"Next card was: {newCard.value}");

        }


        public void DoOutputs()
        {
            // tells you the current score after guessing
            System.Console.WriteLine($"Your score is: {_yourScore}");

        // checks to see if you can keep playing if your score is above 0 you can choose if it is below you end
        if (_yourScore > 0)
        {
            System.Console.WriteLine("Keep playing? ");
            string answer = System.Console.ReadLine();
            if (answer == "n")
            {
                _isPlaying = false;
            }
        }
        else if(_yourScore <= 0)
        {
            _isPlaying = false;
        }
        }

    }
}