string[] LessThanThreeSign(string[] input, int n)
{
    string[] output = new string[GetArray(input, n)];
    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if(input[i].Length <= 0)
        {
            output[j] = input[i];
            j++;
        }
    }
    return output;
}

int GetArray(string[] input, int n)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            count++;
        }
    }
    return count;
}

string[] PrintArray()
{
    Console.WriteLine("Введите значение массива через пробел: ");
    return Console.ReadLine().Split(" ");    
}

Console.Clear();
string[] array = PrintArray();
string[] result = LessThanThreeSign(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

