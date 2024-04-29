namespace _04.fourthDay
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string input = File.ReadAllText("D:\\advent-of-code-2023\\ThirdOfDecember\\input.txt");
            string[] input = File.ReadAllText("C:\\Мартин\\Moi\\advent of code\\SecondOfDecember\\04.fourthDay\\input.txt").Split("\n");

            int points = 0;
            int total = 0;
            int coppyOfWinningCards = 0;
            int original = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string[] tokens = input[i].Split(":");
                string[] bothColons = tokens[1].Split("|");

                string leftSide = bothColons[0].Trim();
                List<string> winningNumbers = leftSide.Split(" ").ToList();
                winningNumbers.RemoveAll(s => string.IsNullOrWhiteSpace(s));

                string rightSide = bothColons[1].Trim();
                List<string> numbersElfHave = rightSide.Split(" ").ToList();
                numbersElfHave.RemoveAll(s => string.IsNullOrWhiteSpace(s));

                int some = 0;

                List<string> finalList = new List<string>();

                for (int j = 0; j < winningNumbers.Count; j++)
                {

                    int currentWiningNumber = int.Parse(winningNumbers[j]);
                    original++;
                    for (int k = 0; k < numbersElfHave.Count; k++)
                    {
                        int currentElfNumber = int.Parse(numbersElfHave[k]);
                        if (currentWiningNumber == currentElfNumber)
                        {

                            coppyOfWinningCards++;
                            if (points == 0)
                            {
                                points = 1;
                            }
                            else
                            {
                                points = points * 2;
                            }
                        }
                    }
                }

                total += points;
                points = 0;

            }

            Console.WriteLine(original);

        }
    }
}
