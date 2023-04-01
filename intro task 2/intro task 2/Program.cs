int[] Numbers = { -1, 2, - 4, 5, 6, -7, 3 };
int sum = 0;
int menfi=0;

for (int i = 0; i < Numbers.Length; i++)
{
	if (Numbers[i] * 1>0)
	{
		sum++;
	}
}
Console.WriteLine("Musbet ededler-"+sum);
menfi = Numbers.Length - sum;
Console.WriteLine("Menfi ededler-"+menfi);