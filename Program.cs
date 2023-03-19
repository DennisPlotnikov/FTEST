
string ReadData(string msg) //Метод чтения массива
 
{
    Console.Write(msg);
    return (Console.ReadLine() ?? "0");
}
 
string arr = ReadData("Введите слова через пробел: ");
 
string[] array1 = arr.Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries).ToArray(); //задаем изначальный массив
string[] array2 = new string[array1.Length]; //задаем новый массив
 
int FilterString(string[] array1, string[] array2) //Метод обработки массива и фильтра строк свыше 3 симв
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
    return j; //выводим перемененную из метода для задания размера массиву
}
 
void Print1DArr(string[] array) //Метод печати нового массива
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
Array.Resize(ref array2, j); //приводим массив к его реальному размеру
Print1DArr(array2);