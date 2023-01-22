//Создайте программу, которая перевернет одномерный массив

int[] GetNewArray(int size, int minValue, int maxValue) //метод создания и заполнения массива
    {
        int[] newArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            newArray[i] = new Random().Next(minValue, maxValue + 1);
        }
        return newArray;
    }
    int[] RotateGettingArray(int[] array, int size) //метод перестановки элементов массива
      //с первого места на последнее и наоборот, со второго на предпоследнее и наоборот и т.д.
    {
        int[] rotatedArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            rotatedArray[i] = array[size - i - 1];
        }
        return rotatedArray;
    }
    void PrintArray(int[] array)      // метод выведения на экран
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
    int[] invertedArray = RotateGettingArray(myArray, count);
    PrintArray(invertedArray);