string s_a = Console.ReadLine();
string s_b = Console.ReadLine();
string s_c = Console.ReadLine();

int a = int.Parse(s_a);
int b = int.Parse(s_b);
int c = int.Parse(s_c);
int max;

max = a;
if (b > a)
    max = b;
if (c > max)
    max = c;
Console.WriteLine("{0} ,max", max);