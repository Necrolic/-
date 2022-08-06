string s_a = Console.ReadLine();
string s_b = Console.ReadLine();

int a = int.Parse(s_a);
int b = int.Parse(s_b);

if(a > b)
{
    Console.WriteLine("{0} ,больше", a);
     Console.WriteLine( "{0} ,меньше", b);
}
else
{
    Console.WriteLine("{0} ,больше", b);
    Console.WriteLine( "{0} ,меньше", a);
}