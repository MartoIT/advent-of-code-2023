
//string input = File.ReadAllText("D:\\advent-of-code-2023\\SecondOfDecember\\input.txt");
string input = File.ReadAllText("C:\\Мартин\\Moi\\advent of code\\SecondOfDecember\\SecondOfDecember\\input.txt");

string[] inputToArray = input.Split("\n");


int redPossibleGame = 12;
int bluePossibleGame = 14;
int greenPossibleGame = 13;

int idOfThePossibleGames = 0;

int chek = 0;

for (int i = 0; i < inputToArray.Length; i++)
{
    int redInHand = 0;
    int blueInHand = 0;
    int greenInHand = 0;
    string current = inputToArray[i];
    string[] newLine = current.Split(": ");

    for (int j = 1; j < newLine.Length; j += 2)
    {
        
        string currentLine = newLine[j];
        string[] currentLine2 = currentLine.Split("; ");
        
        for (int k = 0; k < currentLine2.Length; k++)
        {
           
            string[] chekHend = currentLine2[k].Split("\n");
            for (int l = 0; l < chekHend.Length; l++)
            {
               
                string inside = chekHend[l];
                string[] insideLine = inside.Split(", ");
                for (int m = 0; m < insideLine.Length; m++)
                {

                    Console.WriteLine(insideLine[m]);

                }

                if (redInHand <= redPossibleGame && blueInHand <= bluePossibleGame && greenInHand <= greenPossibleGame)
                {

                    chek = 0;

                }else
                {
                    chek += 1;
                }
                Console.WriteLine("New Line");

            }

            string currentWord = "";
            char currentChar = currentLine[k];

            if (k + 1 < currentLine.Length)
            {

                char nextChar = currentLine[k + 1];
                if (Char.IsDigit(currentChar) && Char.IsDigit(nextChar))
                {

                    int currentDigit = int.Parse($"{currentChar}{nextChar}");
                    string firstLetter = currentLine[k + 3].ToString();
                    string secondLetter = currentLine[k + 4].ToString();
                    string thirdLetter = currentLine[k + 5].ToString();

                    currentWord += $"{firstLetter}{secondLetter}{thirdLetter}";

                    if (currentWord == "red")
                    {
                        redInHand += currentDigit;
                        k++;
                        continue;
                    }

                    if (k + 6 <= currentLine.Length)
                    {
                        string fourthLetter = currentLine[k + 6].ToString();
                        currentWord += $"{fourthLetter}";
                        if (currentWord == "blue")
                        {
                            blueInHand += currentDigit;
                            k++;
                            continue;
                        }
                        if (k + 7 <= currentLine.Length)
                        {

                            string fifthLetter = currentLine[k + 7].ToString();
                            currentWord += $"{fifthLetter}";
                            if (currentWord == "green")
                            {
                                greenInHand += currentDigit;
                                k++;
                                continue;
                            }
                        }


                    }

                }
            }




            if (Char.IsDigit(currentChar))
            {
                int currentDigit = int.Parse($"{currentChar}");
                string firstLetter = currentLine[k + 2].ToString();
                string secondLetter = currentLine[k + 3].ToString();
                string thirdLetter = currentLine[k + 4].ToString();

                currentWord += $"{firstLetter}{secondLetter}{thirdLetter}";
                if (currentWord == "red")
                {
                    redInHand += currentDigit;
                    continue;
                }
                if (k + 5 < currentLine.Length)
                {
                    string fourthLetter = currentLine[k + 5].ToString();
                    currentWord += $"{fourthLetter}";
                    if (currentWord == "blue")
                    {
                        blueInHand += currentDigit;
                        continue;
                    }

                    if (k + 6 < currentLine.Length)
                    {

                        string fifthLetter = currentLine[k + 6].ToString();
                        currentWord += $"{fifthLetter}";
                        if (currentWord == "green")
                        {
                            greenInHand += currentDigit;
                            continue;
                        }
                    }


                }


            }



        }

        
        Console.WriteLine("LINE");

    }
    

    //if (redInHand <= redPossibleGame && blueInHand <= bluePossibleGame && greenInHand <= greenPossibleGame)
    //{

    //    string[] newArr = current.Split("Game ");
    //    string s = string.Join(" ", newArr);
    //    string[] s2 = s.Split(":");
    //    string s3 = string.Join(" ", s2);
    //    string[] s4 = s3.Split(" ");
    //    string s5 = string.Join("", s4);
    //    string possibleNumberOfGame = s4[1];

    //    Console.WriteLine(possibleNumberOfGame);
    //    Console.WriteLine(current);
    //    idOfThePossibleGames += int.Parse(possibleNumberOfGame);

    //}


}

Console.WriteLine(idOfThePossibleGames);
