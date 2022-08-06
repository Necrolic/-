// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

int SumNumb(int M, int N)
{
    if (M > N) return 0;    
    return SumNumb(M, N - 1) + N;
}

Console.WriteLine(SumNumb(2, 19));
Console.WriteLine(SumNumb(5, 9));
