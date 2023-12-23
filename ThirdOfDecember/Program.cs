string input = File.ReadAllText("D:\\advent-of-code-2023\\ThirdOfDecember\\input.txt");
//string input = File.ReadAllText("C:\\Мартин\\Moi\\advent of code\\SecondOfDecember\\SecondOfDecember\\input.txt");

string[] array = input.Split('\n');
int firstLine = 0;
int lastLine = 0;
for (int i = 0; i < array.Length; i++)
{
    string currentRow = array[i];
    if (i == 0)
    {
        firstLine = 1;
    }

    if(i == array.Length - 1)
    {
        lastLine = 1;
    }

    for (int j = 0; j < currentRow.Length; j++)
    {
        Console.WriteLine(currentRow[j]);

    }

    Console.WriteLine("ROW");
}

