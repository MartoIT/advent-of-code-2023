//string input = File.ReadAllText("D:\\advent-of-code-2023\\ThirdOfDecember\\input.txt");
string input = File.ReadAllText("C:\\Мартин\\Moi\\advent of code\\SecondOfDecember\\ThirdOfDecember\\input.txt");

string[] array = input.Split('\n');
int firstLine = 0;
int lastLine = 0;
bool enginPart = false;
int digitPartFromEngine = 0;

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
        char currentSymbol = currentRow[j];
        char previousSymbol = '\0';
        char afterSymbol = '\0';

        int startIndex = -1;
        int endIndex = -1;


        if (Char.IsDigit(currentSymbol))
        {
            currentDigit = int.Parse($"{currentSymbol}");
            if (j > 0)
            {
                previousSymbol = currentRow[j - 1];
                startIndex = j - 1;
                if (previousSymbol != '.' && !Char.IsDigit(previousSymbol))
                {

                    enginPart = true;
                }
            }
        }

        if (j + 1 < currentRow.Length)
        {
            char secondSymbol = currentRow[j + 1];

            if (Char.IsDigit(currentSymbol) && Char.IsDigit(secondSymbol))
            {
                currentDigit = int.Parse($"{currentSymbol}{secondSymbol}");
                j++;
                if(startIndex == -1)
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
                        if(j + 1 < currentRow.Length)
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

        }

        if (j + 1 < currentRow.Length)
        {
            afterSymbol = currentRow[j + 1];
            if (afterSymbol != '.' && !Char.IsDigit(afterSymbol) && afterSymbol != '\0')
            {
                
                enginPart = true;
                j++;
            }
        }

        if (enginPart)
        {
            digitPartFromEngine += currentDigit;
            continue;
        }

        if (firstLine == 0 && currentDigit != 0)
        {
            string rowBefor = array[i - 1];
            for (int k = startIndex; k <= endIndex; k++)
            {
                char symbolInRowAbove = rowBefor[k];
                if(symbolInRowAbove != '.' && !Char.IsDigit(symbolInRowAbove))
                {
                    Console.WriteLine(currentDigit);
                    enginPart = true;
                    
                }
              

                
            }
        }

        if (enginPart)
        {
            digitPartFromEngine += currentDigit;
            continue;
        }

        if (lastLine == 0 && currentDigit != 0)
        {
            string rowAfter = array[i + 1];
            for (int l = startIndex; l <= endIndex; l++)
            {
                char symbolInRowUnder = rowAfter[l];
                if (symbolInRowUnder != '.' && !Char.IsDigit(symbolInRowUnder))
                {
                    Console.WriteLine(currentDigit);
                    enginPart = true;

                }



            }
        }

        if (enginPart)
        {
            digitPartFromEngine += currentDigit;
            continue;
        }


    }

   
}


Console.WriteLine(digitPartFromEngine);
