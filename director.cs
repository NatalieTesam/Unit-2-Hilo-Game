namespace card_game
{
    public class Director
    {
        public bool _isPlaying = true;

        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        public void GetInputs()
        {
            Card theCard = new Card();
            theCard.DrawCard();
            System.Console.WriteLine(theCard.value);
        }

        public void DoUpdates()
        {
            
        }

        public void DoOutputs()
        {
            System.Console.WriteLine("Keep playing? ");
            string answer = System.Console.ReadLine();
            if (answer == "n")
            {
                _isPlaying = false;
            }
        }

    }
}