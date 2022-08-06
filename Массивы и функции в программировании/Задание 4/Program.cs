// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,является ли этот день выходным.
void TheDayOfTheWeek(int num)
{       
    if (num == 6  || num == 7)
    {
        Console.WriteLine($"{num} -> yes");
    }
    else if (num < 1 || num > 7)
    {
    Console.WriteLine($"{num} -> not day");
    }
    else Console.WriteLine($"{num} -> no");           
}

TheDayOfTheWeek(56);