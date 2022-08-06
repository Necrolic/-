// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int chislo(int num)
{
    int count = 0;
    for (int i = 0; i <= num; i++)
    {
        Console.Write($"Число {i}: ");
        int a = int.Parse(Console.ReadLine());
        if (a > 0) count++;
    }

    return count;
}

Console.Write("количество чисел?: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"количество чисел больше 0: {chislo(a)}");

