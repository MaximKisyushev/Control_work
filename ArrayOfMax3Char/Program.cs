Console.WriteLine("*************************************************************************************************************");
Console.WriteLine("*Программа формирует новый массив, из имеющегося массива строк, состоящий из строк длиной максимум 3 символа*");
Console.WriteLine("*************************************************************************************************************");
Console.WriteLine("Заполните исходный массив четырьмя ненулевыми строками: ");
int size = 0;
string[] startArray = new string[4];
for (int i = 0; i < 4; i++)
{
    startArray[i] = Console.ReadLine();
    if (startArray[i] == string.Empty) i--;
    else if (startArray[i].Length <= 3) size++;
}

string[] endArray = new string[size];
for (int j = 0, l = 0; j < startArray.Length; j++)
{
    if (startArray[j].Length <= 3)
    {
        endArray[l] = startArray[j];
        l++;
    }
}

Console.WriteLine($"Start Array: [ {String.Join(", ", startArray)} ] --> End Array  [ {String.Join(", ", endArray)} ]");
