// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

void evenNumers(int M, int N)
{
    if (M > N) return;
    if (M % 2 == 1) M += 1;

    Console.Write($"{M}, ");
    evenNumers(M + 2, N);    
}

evenNumers(3, 9);
Console.WriteLine();
evenNumers(2, 7);