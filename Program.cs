Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = int.Parse(Console.ReadLine()!);
string[] origStr = new string[n];

for (int i = 0; i < origStr.Length; i++)
{
    Console.Write("Введите строку: ");
    origStr[i] = (Console.ReadLine()!);
 }

int count = 0;

foreach (string word in origStr)
{
    if (word.Length <= 3)
    {
        count++;
    }
}

string[] filteredStr = new string[count];
int j = 0;
foreach (string word in origStr)
{
    if (word.Length <= 3)
    {
        filteredStr[j++] = word;
    }
}
Console.WriteLine($"Строки, длина которых 3 и меньше символов: [{string.Join(", ", filteredStr)}]");