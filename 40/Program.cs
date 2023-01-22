//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.

Console.WriteLine ("введите длину первой стороны треугольника");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("введите длину второй стороны треугольника");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("введите длину третьей стороны треугольника");
    int c = Convert.ToInt32(Console.ReadLine());

    if ((a < b + c) && (b < a + c) && (c < a + b))
    {
      Console.WriteLine ("Да! Треугольник со сторонами такой длины может существовать");
    }
    else
    {
      Console.WriteLine ("Нет! Треугольник со сторонами такой длины не может существовать");
    }