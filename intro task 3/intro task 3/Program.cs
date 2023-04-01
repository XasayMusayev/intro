int[] Numbers = { 2,-66, 3, 4,55, 5, 7, 8, 11, 4, 5, 7, 6, 55, 46, 10 };
int bigger= Numbers[0];
for (int i = 1; i < Numbers.Length; i++)
{
	if (Numbers[i]>bigger)
	{
		bigger = Numbers[i];

	}

}
Console.WriteLine(bigger);