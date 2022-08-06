// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

 void Palindrome(int a)
{
    int i = 0;
    string num = a.ToString();
    int size = num.Length - 1;
    string flag = "yes";
    
    while (i < size / 2)
    {
        if (num[i] != num[size - i]) 
        {
            flag = "no";
            break;
        }        
        i += 1;
    }    
    Console.WriteLine($"{a} -> {flag}");
}

Palindrome(14212);
Palindrome(23432);
Palindrome(12821);
