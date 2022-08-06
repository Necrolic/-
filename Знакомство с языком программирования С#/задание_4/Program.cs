string s_N = Console.ReadLine();
int N = int.Parse(s_N);
int m = 1, v = 1;

while (true)
{
	if (m % 2 == 0)
	{
		Console.Write(m + " ");
		v++;
	}
	if (v > N)
	{
		break;
	}
	m++;
}