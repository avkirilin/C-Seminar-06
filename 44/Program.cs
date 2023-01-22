//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фиббоначчи 0 и 1.
int[] GetNewArray(int size)
    {
        int[] newArray = new int[size];
        newArray[0] = 0;
        newArray[1] = 1;
        for (int i = 2; i < size; i++)
        {
            newArray[i] = newArray[i - 1] + newArray[i - 2];
        }
        return newArray;

    }
  void PrintArray(int[] array)
  {
    Console.WriteLine($"[{String.Join(", ", array)}]");
  }
  
Console.WriteLine("Введите длину задаваемого массива");
int count = Convert.ToInt32(Console.ReadLine());
int[] fibonacciArray = GetNewArray(count);
PrintArray(fibonacciArray);