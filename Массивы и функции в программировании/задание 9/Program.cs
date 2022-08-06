// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Summ( int num)
{
    int resultat = 0;
    while (num > 0)
    {
    resultat += num % 10;
    num = num / 10;
    }
    return resultat;
}
Console.WriteLine(Summ(452));
Console.WriteLine(Summ(82));
Console.WriteLine(Summ(9012));
