
string input = File.ReadAllText("D:\\advent-of-code-2023\\SecondOfDecember\\input.txt");
//string input = File.ReadAllText("C:\\Мартин\\Moi\\advent of code\\SecondOfDecember\\SecondOfDecember\\input.txt");

int redPossibleGame = 12;
int greenPossibleGame = 13;
int bluePossibleGame = 14;

int redInHand = 0;
int blueInHand = 0;
int greenInHand = 0;

int idOfThePossibleGames = 0;
int chek = 0;
int doubleChek = 0;

int bigestDigitInHand = 0;
bool checkIsItFirstNumber = true;
int power = 0;
int allPowers = 0;

int biggestRed = 0;
int biggestBlue = 0;
int biggestGreen = 0;

string[] line = input.Split("Game ");
string line2 = string.Join("", line);
string[] line3 = line2.Split(": ");
string line4 = string.Join(" ", line3);
string[] line5 = line4.Split("\n");

for (int i = 0; i < line5.Length; i++)
{
    string[] current = line5[i].Split(' ', 2);
    for (int j = 1; j < current.Length; j++)
    {
        string indexOfGame = current[0];
        string[] lineOfCurrentGame = current[1].Split("; ");


        for (int k = 0; k < lineOfCurrentGame.Length; k++)
        {
            redInHand = 0;
            blueInHand = 0;
            greenInHand = 0;
            string currentHand = lineOfCurrentGame[k];

            for (int l = 0; l < currentHand.Length; l++)
            {
                string currentColor = "";
                int currentDigit;
                char currentSymbol = currentHand[l];

                if (l + 1 < currentHand.Length)
                {
                    char nextSymbol = currentHand[l + 1];
                    if (Char.IsDigit(currentSymbol) && Char.IsDigit(nextSymbol))
                    {
                        currentDigit = int.Parse($"{currentSymbol}{nextSymbol}");

                        string firstLetter = currentHand[l + 3].ToString();
                        string secondLetter = currentHand[l + 4].ToString();
                        string thirdLetter = currentHand[l + 5].ToString();

                        currentColor += $"{firstLetter}{secondLetter}{thirdLetter}";

                        if (currentColor == "red")
                        {
                            if (redInHand < currentDigit)
                            {
                                redInHand = currentDigit;
                            }

                            l++;
                            continue;
                        }


                        if (l + 6 < currentHand.Length)
                        {
                            string fourthLetter = currentHand[l + 6].ToString();
                            currentColor += $"{fourthLetter}";
                            if (currentColor == "blue")
                            {
                                if (blueInHand < currentDigit)
                                {
                                    blueInHand = currentDigit;
                                }

                                l++;
                                continue;
                            }

                            if (l + 7 < currentHand.Length)
                            {

                                string fifthLetter = currentHand[l + 7].ToString();
                                currentColor += $"{fifthLetter}";
                                if (currentColor == "green")
                                {
                                    if (greenInHand < currentDigit)
                                    {
                                        greenInHand = currentDigit;
                                    }

                                    l++;
                                    continue;
                                }
                            }

                        }
                    }
                    else if (Char.IsDigit(currentSymbol))
                    {
                        currentDigit = int.Parse($"{currentSymbol}");
                        string firstLetter = currentHand[l + 2].ToString();
                        string secondLetter = currentHand[l + 3].ToString();
                        string thirdLetter = currentHand[l + 4].ToString();

                        currentColor += $"{firstLetter}{secondLetter}{thirdLetter}";
                        if (currentColor == "red")
                        {
                            if (redInHand < currentDigit)
                            {
                                redInHand = currentDigit;
                            }

                            continue;
                        }

                        if (l + 5 < currentHand.Length)
                        {
                            string fourthLetter = currentHand[l + 5].ToString();
                            currentColor += $"{fourthLetter}";
                            if (currentColor == "blue")
                            {
                                if (blueInHand < currentDigit)
                                {
                                    blueInHand = currentDigit;
                                }

                                continue;
                            }

                            if (l + 6 < currentHand.Length)
                            {

                                string fifthLetter = currentHand[l + 6].ToString();
                                currentColor += $"{fifthLetter}";
                                if (currentColor == "green")
                                {
                                    if (greenInHand < currentDigit)
                                    {
                                        greenInHand = currentDigit;
                                    }

                                    continue;
                                }
                            }


                        }
                    }
                    else
                    {
                        continue;
                    }
                }


            }


            if (redInHand > biggestRed)
            {
                biggestRed = redInHand;
            }

            if (blueInHand > biggestBlue)
            {
                biggestBlue = blueInHand;
            }

            if (greenInHand > biggestGreen)
            {
                biggestGreen = greenInHand;
            }


        }

        power = biggestRed;
        power *= biggestGreen;
        power *= biggestBlue;
        allPowers += power;
        
        biggestRed = 0;
        biggestBlue = 0;
        biggestGreen = 0;
        

    }

}


Console.WriteLine(allPowers);
