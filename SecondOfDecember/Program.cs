
string input = File.ReadAllText("C:\\Мартин\\Moi\\advent of code\\SecondOfDecember\\SecondOfDecember\\input.txt");

string[] inputToArray = input.Split("\n");
int redInHand = 0;
int blueInHand = 0;
int greenInHand = 0;

for (int i = 0; i < inputToArray.Length; i++)
{
    string current = inputToArray[i];
    string[] newLine = current.Split(": ");

    for (int j = 1; j < newLine.Length; j += 2)
    {
        string currentLine = newLine[j];

        for (int k = 0; k < currentLine.Length; k++)
        {
            string currentWord = "";
            char currentChar = currentLine[k];

            if (Char.IsDigit(currentChar))
            {
                char nextChar = currentLine[k+1];
                string firstLetter = currentLine[k + 2].ToString();
                string secondLetter = currentLine[k + 3].ToString();
                string thirdLetter = currentLine[k + 4].ToString();
                currentWord += $"{firstLetter}{secondLetter}{thirdLetter}";
                if(currentWord == "red")
                {
                    redInHand += int.Parse($"{currentChar}");
                    continue;
                }
                if (k + 5 < currentLine.Length)
                {
                    string fourthLetter = currentLine[k + 5].ToString();
                    currentWord += $"{fourthLetter}";
                    if (currentWord == "blue")
                    {
                        blueInHand += int.Parse($"{currentChar}");
                        continue;
                    }

                    if (k + 6 < currentLine.Length)
                    {

                        string fifthLetter = currentLine[k + 6].ToString();
                        currentWord += $"{fifthLetter}";
                        if (currentWord == "green")
                        {
                            greenInHand += int.Parse($"{currentChar}");
                            continue;
                        }
                    }


                }

                if (Char.IsDigit(nextChar))
                {

                    currentWord = "";
                     firstLetter = currentLine[k + 3].ToString();
                     secondLetter = currentLine[k + 4].ToString();
                     thirdLetter = currentLine[k + 5].ToString();

                    currentWord += $"{firstLetter}{secondLetter}{thirdLetter}";

                    if (k + 6 < currentLine.Length)
                    {
                        string fourthLetter = currentLine[k + 5].ToString();
                        currentWord += $"{fourthLetter}";

                        if (k + 7 < currentLine.Length)
                        {

                            string fifthLetter = currentLine[k + 6].ToString();
                            currentWord += $"{fifthLetter}";
                        }


                    }

                }
         
                

                
                Console.WriteLine(currentWord);
                
               
            }

        }

    }


}
