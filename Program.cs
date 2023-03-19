string ReadData(string msg)
 
{
    Console.Write(msg);
    return (Console.ReadLine() ?? "0");
}
 
string arr = ReadData("Введите слова через пробел: ");
 
string[] array1 = arr.Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
string[] array2 = new string[array1.Length];
 
int FilterString(string[] array1, string[] array2)
{
 
    int j = 0;
 
    for (int i = 0; i < array1.Length; i++)
 
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }
 
    }
    return j;
}
 
void Print1DArr(string[] array)
{
 
    Console.Write("['");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + "', '");
    }
    Console.WriteLine(array[array.Length - 1] + "']");
 
}
 
Print1DArr(array1);
FilterString(array1, array2);
int j = FilterString(array1, array2);
Array.Resize(ref array2, j);
Print1DArr(array2);