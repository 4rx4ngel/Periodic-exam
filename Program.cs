string[] GetArrayStringConsole (string consoleSymbol)
{
    string[] arraySymbol = new string[consoleSymbol.Length];
    arraySymbol = consoleSymbol.Split(' ');
    return arraySymbol;
}

string[] GetArrayThreeSymbol (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string symbol = array[i];
        if (symbol.Length <= 3)
        {
            count++;
        }
    }
    string[] arrayThreeSymbol = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string symbol = array[i];
        if (symbol.Length <= 3)
        {
            arrayThreeSymbol[j] = symbol;
            j++;
        }
    }
    return arrayThreeSymbol;
}

void Print (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("");

}

Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;

Console.Clear();

Console.Write("Введите набор символов через пробел: ");
string[] arraySymbol = GetArrayStringConsole(Console.ReadLine()!);
string[] arrayThreeSymbol = GetArrayThreeSymbol(arraySymbol);

Console.Clear();

Console.Write("Введенные символы: ");
Print(arraySymbol);

Console.WriteLine();

Console.Write("Введенные символы длиной меньше либо равны 3: ");
Print(arrayThreeSymbol);

Console.WriteLine();


