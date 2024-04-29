namespace _04.fourthDay
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string input = File.ReadAllText("D:\\advent-of-code-2023\\ThirdOfDecember\\input.txt");
            string[] input1 = File.ReadAllText("C:\\Мартин\\Moi\\advent of code\\SecondOfDecember\\04.fourthDay\\input.txt").Split("\n");
            
            List<string> input = input1.ToList();

            int points = 0;
            int total = 0;
            List<string> finalList = new List<string>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                finalList.Add(input[i]);
                break;
            }

            for (int i = 0; i < input.Count; i++)
            {
                string[] tokens = input[i].Split(":");
                string[] bothColons = tokens[1].Split("|");

                string leftSide = bothColons[0].Trim();
                List<string> winningNumbers = leftSide.Split(" ").ToList();
                winningNumbers.RemoveAll(s => string.IsNullOrWhiteSpace(s));

                string rightSide = bothColons[1].Trim();
                List<string> numbersElfHave = rightSide.Split(" ").ToList();
                numbersElfHave.RemoveAll(s => string.IsNullOrWhiteSpace(s));
               
                if(i == 0 )
                {
                    finalList.Add(input[i]);
                }
               
                for (int j = 0; j < winningNumbers.Count; j++)
                {
                   
                    int currentWiningNumber = int.Parse(winningNumbers[j]);
                    
                    for (int k = 0; k < numbersElfHave.Count; k++)
                    {
                        int currentElfNumber = int.Parse(numbersElfHave[k]);
                        if(currentWiningNumber == currentElfNumber)
                        {                          
                                points++;
                        }
                    }
                }
                if(points == 0)
                {
                    finalList.Add(input[i]);
                }
                else
                {
                    for (int j = 1; j <= points; j++)
                    {

                        input.Add(input[i + j]);
                        finalList.Add(input[i + j]);


                    }
                }

               
                points = 0;

            }
        
            for (int i = 0; i <  finalList.Count; i++)
            {
                string[] tokens = finalList[i].Split(":");
                string[] bothColons = tokens[1].Split("|");

                string leftSide = bothColons[0].Trim();
                List<string> winningNumbers = leftSide.Split(" ").ToList();
                winningNumbers.RemoveAll(s => string.IsNullOrWhiteSpace(s));

                string rightSide = bothColons[1].Trim();
                List<string> numbersElfHave = rightSide.Split(" ").ToList();
                numbersElfHave.RemoveAll(s => string.IsNullOrWhiteSpace(s));

                for (int j = 0; j < winningNumbers.Count; j++)
                {

                    int currentWiningNumber = int.Parse(winningNumbers[j]);

                    for (int k = 0; k < numbersElfHave.Count; k++)
                    {
                        int currentElfNumber = int.Parse(numbersElfHave[k]);
                        if (currentWiningNumber == currentElfNumber)
                        {

                           
                            if (points == 0)
                            {
                                points = 1;
                            }
                            else
                            {
                                points++;
                            }
                        }
                    }
                }

                Console.WriteLine(finalList[i]);

                total += points;
                points = 0;

            }


            Console.WriteLine(total);
        }
    }
}
