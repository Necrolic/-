// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


void ThirdNum(int num)
{
    Console.WriteLine($"{num} -> ");
    int tr_num = 0;
    string txt;

    while (num > 99)
    {
        tr_num = num % 10;
        num =num / 10;
    }
    txt = $"{tr_num}";
    if (tr_num == 0)
    {
        txt = "no third digit";
    }
     Console.WriteLine(txt);
}
ThirdNum(45);