
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
                int redInHand = 0;
                int blueInHand = 0;
                int greenInHand = 0;

                for (int m = 0; m < inside.Length; m++)
                {

                    string currentWord = "";
                    char currentChar = inside[m];
                  
                    if (m + 1 < inside.Length)
                    {

                        char nextChar = inside[m + 1];
                        if (Char.IsDigit(currentChar) && Char.IsDigit(nextChar))
                        {

                            int currentDigit = int.Parse($"{currentChar}{nextChar}");
                            string firstLetter = inside[m + 3].ToString();
                            string secondLetter = inside[m + 4].ToString();
                            string thirdLetter = inside[m + 5].ToString();

                            currentWord += $"{firstLetter}{secondLetter}{thirdLetter}";

                            if (currentWord == "red")
                            {
                                redInHand += currentDigit;
                                m++;
                                continue;
                            }

                            if (m + 6 <= inside.Length)
                            {
                                string fourthLetter = inside[m + 6].ToString();
                                currentWord += $"{fourthLetter}";
                                if (currentWord == "blue")
                                {
                                    blueInHand += currentDigit;
                                    m++;
                                    continue;
                                }
                                if (m+ 7 <= inside.Length)
                                {

                                    string fifthLetter = inside[m + 7].ToString();
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
                        string firstLetter = inside[m + 2].ToString();
                        string secondLetter = inside[m + 3].ToString();
                        string thirdLetter = inside[m + 4].ToString();

                        currentWord += $"{firstLetter}{secondLetter}{thirdLetter}";
                        if (currentWord == "red")
                        {
                            redInHand += currentDigit;
                            continue;
                        }
                        if (m + 5 < inside.Length)
                        {
                            string fourthLetter = inside[m + 5].ToString();
                            currentWord += $"{fourthLetter}";
                            if (currentWord == "blue")
                            {
                                blueInHand += currentDigit;
                                continue;
                            }

                            if (m + 6 < inside.Length)
                            {

                                string fifthLetter = inside[m + 6].ToString();
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

                if (redInHand < redPossibleGame && blueInHand < bluePossibleGame && greenInHand < greenPossibleGame)
                {

                    

                }else
                {
                    chek++;
                }
                

            }

           

        }
        if (chek == 0)
        {
            string[] newArr = current.Split("Game ");
            string s = string.Join(" ", newArr);
            string[] s2 = s.Split(":");
            string s3 = string.Join(" ", s2);
            string[] s4 = s3.Split(" ");
            Console.WriteLine(current);
            string possibleNumberOfGame = s4[1];
            idOfThePossibleGames += int.Parse(possibleNumberOfGame);


        }
        chek = 0;



    }



}

Console.WriteLine(idOfThePossibleGames);