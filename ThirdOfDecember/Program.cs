//string input = File.ReadAllText("D:\\advent-of-code-2023\\ThirdOfDecember\\input.txt");
string input = File.ReadAllText("C:\\Мартин\\Moi\\advent of code\\SecondOfDecember\\ThirdOfDecember\\input.txt");

string[] array = input.Split('\n');
int firstLine = 0;
int lastLine = 0;
bool enginPart = false;
int digitPartFromEngine = 0;

bool gotAGear = false;

for (int i = 0; i < array.Length; i++)
{
    string currentRow = array[i];
    if (i == 0)
    {
        firstLine = 1;
    }
    else
    {
        firstLine = 0;
    }

    if (i == array.Length - 1)
    {
        lastLine = 1;
    }

    for (int j = 0; j < currentRow.Length; j++)
    {
        enginPart = false;
        int currentDigit = 0;
        int nextDigit = 0;
        char currentSymbol = currentRow[j];
        char nextSymbol = '\0';
        char previousSymbol = '\0';
        char afterSymbol = '\0';

        int multiplying = 0;
        int startIndex = -1;
        int endIndex = -1;

        int insideStartIndex = -1;
        int insideEndIndex = -1;


        if (Char.IsDigit(currentSymbol))
        {
            currentDigit = int.Parse($"{currentSymbol}");
            if (j > 0)
            {
                startIndex = j - 1;
             
            }
        }

        if (j + 1 < currentRow.Length)
        {
            char secondSymbol = currentRow[j + 1];

            if (Char.IsDigit(currentSymbol) && Char.IsDigit(secondSymbol))
            {
                currentDigit = int.Parse($"{currentSymbol}{secondSymbol}");
                j++;
                if (startIndex == -1)
                {
                    startIndex = j;
                }

                if (j + 1 < currentRow.Length)
                {
                    endIndex = j + 1;
                }
                else
                {
                    endIndex = j;
                }
                if (j + 1 < currentRow.Length)
                {
                    char thirdSymbol = currentRow[j + 1];

                    if (Char.IsDigit(currentSymbol) && Char.IsDigit(secondSymbol) && Char.IsDigit(thirdSymbol))
                    {
                        currentDigit = int.Parse($"{currentSymbol}{secondSymbol}{thirdSymbol}");
                        j++;
                        if (j + 1 < currentRow.Length)
                        {
                            endIndex = j + 1;
                        }
                        else
                        {
                            endIndex = j;
                        }

                    }


                }

            }
            else
            {
                if (startIndex == -1)
                {
                    startIndex = j;
                }

                if (j + 1 < currentRow.Length)
                {
                    endIndex = j + 1;
                }
                else
                {
                    endIndex = j;
                }
            }

        }

        if (j + 1 < currentRow.Length)
        {
            j++;
            afterSymbol = currentRow[j];
            if (afterSymbol == '*')
            {
                if (j + 1 < currentRow.Length)
                {
                    j++;
                    nextSymbol = currentRow[j];

                    if (Char.IsDigit(nextSymbol))
                    {
                        nextDigit = int.Parse($"{nextSymbol}");

                    }

                    if (j + 1 < currentRow.Length)
                    {
                        char nextSecondSymbol = currentRow[j + 1];

                        if (Char.IsDigit(nextSymbol) && Char.IsDigit(nextSecondSymbol))
                        {
                            nextDigit = int.Parse($"{nextSymbol}{nextSecondSymbol}");
                            j++;

                            if (j + 1 < currentRow.Length)
                            {
                                char nextThirdSymbol = currentRow[j + 1];

                                if (Char.IsDigit(nextSymbol) && Char.IsDigit(nextSecondSymbol) && Char.IsDigit(nextThirdSymbol))
                                {
                                    nextDigit = int.Parse($"{nextSymbol}{nextSecondSymbol}{nextThirdSymbol}");
                                    j++;
                                }


                            }

                        }


                    }
                }

            }
        }

        if (currentDigit != 0 && nextDigit != 0)
        {
            multiplying = currentDigit * nextDigit;
            Console.WriteLine(multiplying);

        }


        if (lastLine == 0 && currentDigit != 0 && startIndex != -1 && endIndex != -1)
        {
            string rowAfter = array[i + 1];
            for (int l = startIndex; l <= endIndex; l++)
            {
                char symbolInRowUnder = rowAfter[l];
                if (symbolInRowUnder != '*')
                {
                    insideStartIndex = l;
                    insideEndIndex = l;

                    string insideRight = array[i + 2];
                    if(insideEndIndex + 3 <= insideRight.Length)
                    {
                        insideEndIndex = l + 3;
                    }else if(insideEndIndex + 2 <= insideRight.Length)
                    {
                        insideEndIndex = l + 2;
                    }
                    else if (insideEndIndex + 1 <= insideRight.Length)
                    {
                        insideEndIndex = l + 1;
                    }else
                    {
                        insideEndIndex = l;
                    }

                    for (int m = insideStartIndex; m <= insideEndIndex; m++)
                    {
                       
                    }

                }



            }
        }

        //if (enginPart)
        //{

        //    digitPartFromEngine += currentDigit;
        //    continue;
        //}


    }


}


Console.WriteLine(digitPartFromEngine);
