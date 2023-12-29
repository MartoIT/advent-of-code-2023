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
            digitPartFromEngine += multiplying;

        }


        if (lastLine == 0 && currentDigit != 0 && startIndex != -1 && endIndex != -1)
        {
            string rowAfter = array[i + 1];
            for (int l = startIndex; l <= endIndex; l++)
            {
                char symbolInRowUnder = rowAfter[l];
                if (symbolInRowUnder == '*')
                {
                    insideStartIndex = l;
                    insideEndIndex = l;

                    string insideRight = array[i + 2];
                    if (insideRight[l - 3] >= 0)
                    {
                        insideStartIndex = l - 3;
                    }
                    else if (insideRight[l - 2] >= 0)
                    {
                        insideStartIndex = l - 2;
                    }
                    else if (insideRight[l - 1] >= 0)
                    {
                        insideStartIndex = l - 1;
                    }
                    else
                    {
                        insideStartIndex = l;
                    }
                    ///////////////////////////////////////////////////////

                    if (insideEndIndex + 3 <= insideRight.Length)
                    {
                        insideEndIndex = l + 3;
                    }
                    else if (insideEndIndex + 2 <= insideRight.Length)
                    {
                        insideEndIndex = l + 2;
                    }
                    else if (insideEndIndex + 1 <= insideRight.Length)
                    {
                        insideEndIndex = l + 1;
                    }
                    else
                    {
                        insideEndIndex = l;
                    }

                    for (int m = insideStartIndex; m <= insideEndIndex; m++)
                    {

                        int nestedDigit = 0;
                        char nestedSymbol = insideRight[m];
                        int nestedIndexOf = -1;
                        int nestedIndexOf2 = -1;

                        if (Char.IsDigit(nestedSymbol))
                        {
                            nestedDigit = int.Parse($"{nestedSymbol}");
                            nestedIndexOf = m;
                        }

                        if (m + 1 < insideRight.Length)
                        {
                            char nestedSecondSymbol = insideRight[m + 1];

                            if (Char.IsDigit(nestedSymbol) && Char.IsDigit(nestedSecondSymbol))
                            {
                                nestedDigit = int.Parse($"{nestedSymbol}{nestedSecondSymbol}");
                                m++;
                                if (nestedIndexOf == -1)
                                {
                                    nestedIndexOf = m;
                                }

                                if (m + 1 < insideRight.Length)
                                {
                                    nestedIndexOf2 = m + 1;
                                }
                                else
                                {
                                    nestedIndexOf2 = m;
                                }


                                if (m + 1 < currentRow.Length)
                                {
                                    char nestedThirdSymbol = insideRight[m + 1];

                                    if (Char.IsDigit(nestedSymbol) && Char.IsDigit(nestedSecondSymbol) && Char.IsDigit(nestedThirdSymbol))
                                    {
                                        nestedDigit = int.Parse($"{nestedSymbol}{nestedSecondSymbol}{nestedThirdSymbol}");
                                        m++;
                                        if (m + 1 < insideRight.Length)
                                        {
                                            nestedIndexOf2 = m + 1;
                                        }
                                        else
                                        {
                                            nestedIndexOf2 = m;
                                        }
                                    }

                                }

                            }


                        }
                        else
                        {
                            if (nestedIndexOf == -1)
                            {
                                nestedIndexOf2 = m;
                            }

                            if (m + 1 < insideRight.Length)
                            {
                                nestedIndexOf2 = m + 1;
                            }
                            else
                            {
                                nestedIndexOf2 = m;
                            }
                        }


                        if (nestedDigit != 0 && nestedIndexOf - 1 <= l && nestedIndexOf2 + 1 < l)
                        {


                            multiplying = currentDigit * nestedDigit;
                            Console.WriteLine(currentDigit);
                            Console.WriteLine(nestedDigit);
                            digitPartFromEngine += multiplying;

                        }


                    }

                }



            }
        }



    }


}


Console.WriteLine(digitPartFromEngine);
