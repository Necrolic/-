// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cubs(int num)
{
    int i = 1;
    Console.Write($"{num} -> ");

    while (num >= i)
    {
        Console.Write($"{Math.Pow(i, 3)}, ");
        i++;
    }
    Console.WriteLine();
}

Cubs(5);
Cubs(11);