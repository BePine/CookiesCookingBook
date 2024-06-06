namespace Helpers
{
    public class Parsing
    {
        public bool IsNumber { get; private set; }
        public int Number { get; private set; } = 0;
        public Parsing(string inputNumber)
        {

            IsNumber = ParseChoice(inputNumber);
            if (IsNumber)
            {
                Number = int.Parse(inputNumber);
            }
        }
        public bool ParseChoice(string input) => int.TryParse(input, out int number);

    }
}

