using System;
#region 1.
int[] numbr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int evenNumber = numbr.Count(n => n % 2 == 0);
int oddNumber = numbr.Count(n=> n % 2 != 0);

int uniqueNumber = numbr.Distinct().Count();

Console.WriteLine("Чётные" + evenNumber);
Console.WriteLine("Нечётных" + oddNumber);
Console.WriteLine("Уникальные"+ uniqueNumber);

#endregion

#region 2.
int[] number1 = { 1, 3, 5, 7, 9, 11, 13, 15 };

Console.WriteLine("Введи число");
int arr = int.Parse(Console.ReadLine());

int count = 0;
    foreach ( int element in number1)
{
    if (element < arr)
    {
        count++;
    }
}
Console.WriteLine($"Количество элементов в массиве меньше {arr}: {count}");
#endregion

#region 3.
int[] arr1 = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
Console.Write("Введите три числа через пробел: ");
int[] sequence = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count1 = 0;
for (int i = 0; i < arr1.Length - 2; i++)
{
    if (arr1[i] == sequence[0] && arr1[i + 1] == sequence[1] && arr1[i + 2] == sequence[2]) count1++;
}
Console.WriteLine($"Количество повторений последовательности: {count1}");
#endregion
#region 4.
int[] arr2 = { 1, 2, 3, 4, 5 };
int[] arr3 = { 3, 4, 5, 6, 7 };
int[] arr4= arr1.Intersect(arr2).Distinct().ToArray();

foreach (int n in arr3)
{
    Console.Write(n + " ");
}
#endregion
#region 5.
int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };
int min = array[0, 0], max = array[0, 0];

foreach (int value in array)
{
    if (value < min)
    {
        min = value;
    }

    if (value > max)
    {
        max = value;
    }
}

Console.WriteLine($"Минимальное значение: {min}");
Console.WriteLine($"Максимальное значение: {max}");
#endregion
#region 6.
Console.Write("Введите предложение: ");
string input = Console.ReadLine()?.Trim();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Вы ввели пустую строку.");
    return;
}

int wordCount = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
Console.WriteLine($"Количество слов в предложении: {wordCount}");
#endregion
#region 7.
Console.WriteLine("Введите предложение:");
string input1 = Console.ReadLine();

string[] words = input.Split(' ');

for (int i = 0; i < words.Length; i++)
{
    char[] chars = words[i].ToCharArray();
    Array.Reverse(chars);
    words[i] = new string(chars);
}

string output = string.Join(" ", words);
Console.WriteLine(output);
#endregion

#region 8.
Console.WriteLine("Введите предложение:");
string input3 = Console.ReadLine();
int vowelCount = input.ToLower().Count(c => "aeiouy".Contains(c));
Console.WriteLine($"Количество гласных букв: {vowelCount}");
#endregion

#region 9 .
Console.WriteLine("Введите строку:");
string input4 = Console.ReadLine();

Console.WriteLine("Введите подстроку для поиска:");
string search = Console.ReadLine();

int count12 = CountOccurrences(input4, search);

Console.WriteLine($"Количество вхождений: {count}");

static int CountOccurrences(string input, string search)
{
    int count = 0;
    int i = 0;

    while ((i = input.IndexOf(search, i, StringComparison.CurrentCultureIgnoreCase)) != -1)
    {
        count++;
        i += search.Length;
    }

    return count;
}
#endregion