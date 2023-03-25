Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine()); 

string[] ArrStrings = new string[size]; 
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите элемент №{i+1}:  ");
    string elem = Convert.ToString(Console.ReadLine() ?? "0");
    ArrStrings[i] = elem;
}

string[] ResultingArr = new string[size];
int length = 3;
int count = 0;

for (int j = 0; j < size; j++)
{
    if (ArrStrings[j].Length <= length)
    {
        ResultingArr[count] = ArrStrings[j];
        count++;
    }
}

void PrintArray(string[] arr) //метод печати
{
    Console.Write ("["); //скобка слева
    for (int i=0; i<arr.Length-1; i++)
    {
        Console.Write($"{arr[i]} "); //выводим массив через запятую
    }
    Console.WriteLine($"{arr[arr.Length-1]}]");
}    // выводим последний элемент массива и правую скобку



PrintArray(ArrStrings);
Console.ForegroundColor =ConsoleColor.DarkRed;
PrintArray(ResultingArr);
Console.ResetColor();
