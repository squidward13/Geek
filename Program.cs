string[] array = { "Russia", "-2", "hello", ":-)" };
int count = 0;
int index = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) count++;
}

string[] result = new string[count];

for (int j = 0; j < array.Length; j++)
{
    if (array[j].Length <= 3)
    {
        result[index] = array[j];
        index++;
    }
}

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"{array[i]}");
}

Console.WriteLine();

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine($"{result[i]}");
}