
string input = File.ReadAllText("D:\\advent-of-code-2023\\SecondOfDecember\\input.txt");

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

            if(k+1 < currentLine.Length) 
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
                        Console.WriteLine(currentDigit);
                        Console.WriteLine(currentWord);
                        k++;
                        continue;
                    }

                    if (k + 6 <= currentLine.Length)
                    {
                        string fourthLetter = currentLine[k + 6].ToString();
                        currentWord += $"{fourthLetter}";
                        if (currentWord == "blue")
                        {
                            Console.WriteLine(currentDigit);
                            Console.WriteLine(currentWord);
                            k++;
                            continue;
                        }
                        if (k + 7 <= currentLine.Length)
                        {

                            string fifthLetter = currentLine[k + 7].ToString();
                            currentWord += $"{fifthLetter}";
                            if (currentWord == "green")
                            {
                                Console.WriteLine(currentDigit);
                                Console.WriteLine(currentWord);
                                k++;
                                continue;
                            }
                        }


                    }

                }
            }
            

            
           
            if (Char.IsDigit(currentChar))
            {
                string firstLetter = currentLine[k + 2].ToString();
                string secondLetter = currentLine[k + 3].ToString();
                string thirdLetter = currentLine[k + 4].ToString();

                currentWord += $"{firstLetter}{secondLetter}{thirdLetter}";
                if(currentWord == "red")
                {
                    //redInHand += int.Parse($"{currentChar}");
                    Console.WriteLine(currentChar);
                    Console.WriteLine(currentWord);
                    continue;
                }
                if (k + 5 < currentLine.Length)
                {
                    string fourthLetter = currentLine[k + 5].ToString();
                    currentWord += $"{fourthLetter}";
                    if (currentWord == "blue")
                    {
                        Console.WriteLine(currentChar);
                        Console.WriteLine(currentWord);
                        //blueInHand += int.Parse($"{currentChar}");
                        continue;
                    }

                    if (k + 6 < currentLine.Length)
                    {

                        string fifthLetter = currentLine[k + 6].ToString();
                        currentWord += $"{fifthLetter}";
                        if (currentWord == "green")
                        {
                            Console.WriteLine(currentChar);
                            Console.WriteLine(currentWord);
                            //greenInHand += int.Parse($"{currentChar}");
                            continue;
                        }
                    }


                }
                
               
            }

            

        }

    }


}
