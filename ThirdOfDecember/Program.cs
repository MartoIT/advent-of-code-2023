//string input = File.ReadAllText("D:\\advent-of-code-2023\\ThirdOfDecember\\input.txt");
string input = File.ReadAllText("C:\\Мартин\\Moi\\advent of code\\SecondOfDecember\\ThirdOfDecember\\input.txt");

string[] array = input.Split('\n');
int firstLine = 0;
int lastLine = 0;


Console.WriteLine(input);

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
        char previousSymbol = '\0';
        char endSymbol = '\0';


        if (Char.IsDigit(currentSymbol))
        {
            currentDigit = int.Parse($"{currentSymbol}");

        }

        if (j + 1 < currentRow.Length)
        {
            char secondSymbol = currentRow[j + 1];

            if (Char.IsDigit(currentSymbol) && Char.IsDigit(secondSymbol))
            {
                currentDigit = int.Parse($"{currentSymbol}{secondSymbol}");
                j++;

                if (j + 1 < currentRow.Length)
                {
                    char thirdSymbol = currentRow[j + 1];

                    if (Char.IsDigit(currentSymbol) && Char.IsDigit(secondSymbol) && Char.IsDigit(thirdSymbol))
                    {
                        currentDigit = int.Parse($"{currentSymbol}{secondSymbol}{thirdSymbol}");
                        j++;
                    }


                }

            }

        }




    }

    Console.WriteLine("ROW");
}

