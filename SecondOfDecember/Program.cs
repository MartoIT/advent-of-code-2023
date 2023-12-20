
string input = File.ReadAllText("C:\\Мартин\\Moi\\advent of code\\SecondOfDecember\\SecondOfDecember\\input.txt");

string[] inputToArray = input.Split("\n");


for (int i = 0; i < inputToArray.Length; i++)
{
    string current = inputToArray[i];
    string[] newLine = current.Split(": ");

    for (int j = 1; j < newLine.Length; j += 2)
    {
        string currentLine = newLine[j];

        for (int k = 0; k < currentLine.Length; k++)
        {
            char currentChar = currentLine[k];

            if (Char.IsDigit(currentChar))
            {
                string currentWord = "";
                string firstLetter = currentLine[k+2].ToString();
                string secondLetter = currentLine[k+3].ToString();
                string thirdLetter = currentLine[k+4].ToString();
               
                currentWord += $"{firstLetter}{secondLetter}{thirdLetter}";

                if (currentLine[k+5] < currentLine.Length)
                {
                    string fourthLetter = currentLine[k+5].ToString();
                    currentWord += $"{fourthLetter}";

                    if (currentLine[k + 6] < currentLine.Length)
                    {

                        string fifthLetter = currentLine[k + 6].ToString();
                        currentWord += $"{fifthLetter}";
                    }


                }

                Console.WriteLine(currentWord);
                
               
            }

        }

    }


}
