string input = File.ReadAllText("D:\\advent-of-code-2023\\ThirdOfDecember\\input.txt");
//string input = File.ReadAllText("C:\\Мартин\\Moi\\advent of code\\SecondOfDecember\\SecondOfDecember\\input.txt");

string[] array = input.Split('\n');
int firstLine = 0;
int lastLine = 0;

int[] myArray = new int[];
var tempList = myArray.ToList();
tempList.Add(5);
myArray = tempList.ToArray();


for (int i = 0; i < array.Length; i++)
{
    string currentRow = array[i];
    if (i == 0)
    {
        firstLine = 1;
    }

    if (i == array.Length - 1)
    {
        lastLine = 1;
    }

    for (int j = 0; j < currentRow.Length; j++)
    {
        int currentDigit;
        char currentSymbol = currentRow[j];
        char previousSymbol = currentRow[j];
        char endSymbol = currentRow[j];

        if (Char.IsDigit(currentSymbol))
        {
            currentDigit = int.Parse($"{currentSymbol}");
            if (j - 1 >= 0)
            {
                previousSymbol = currentRow[j - 1];
            }
        }

        if (j + 1 < currentRow.Length)
        {
            char nextSymbol = currentRow[j + 1];

            if (Char.IsDigit(currentSymbol) && Char.IsDigit(nextSymbol))
            {
                currentDigit = int.Parse($"{currentSymbol}{nextSymbol}");
                j++;

                if (j + 1 < currentRow.Length)
                {
                    char thirdSymbol = currentRow[j + 1];

                    if (Char.IsDigit(currentSymbol) && Char.IsDigit(nextSymbol) && Char.IsDigit(thirdSymbol))
                    {
                        currentDigit = int.Parse($"{currentSymbol}{nextSymbol}{thirdSymbol}");
                        j++;
                    }else
                    {
                        endSymbol = thirdSymbol;
                    }

                    if (j + 1 < currentRow.Length)
                    {
                        endSymbol = thirdSymbol;
                    }

                }

            } else
            {
                endSymbol = nextSymbol;
            }




        }



    }

    Console.WriteLine("ROW");
}

