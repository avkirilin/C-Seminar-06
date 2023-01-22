//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.int[] GetNewArray(int size, int minValue, int maxValue) //метод создания и заполнения массива
int[] GetNewArray(int size, int minValue, int maxValue)                     //метод создания и заполнения массива
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}
int[] CopyArray(int[] array, int size)                                      //метод создания копии массива поэлементно
{
    int[] similarArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        similarArray[i] = array[i];
    }
    return similarArray;
}
void PrintArray(int[] array)                                                //метод печати массива
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}

Console.WriteLine("Введите длину задаваемого массива");
int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение, принимаемое элементом массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальноее значение, принимаемое элементом массива");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = GetNewArray(count, min, max);
PrintArray(myArray);
int[] copiedArray = CopyArray(myArray, count);
PrintArray(copiedArray);
