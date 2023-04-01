
int point = 100;
if (point>=0&&point<=100)
{
	if (point>90)
	{
		Console.WriteLine("A");

	}
	else if (point>80)
	{
		Console.WriteLine("B");
			
	}
	else if (point>70)
	{
		Console.WriteLine("C");
	}
	else if (point>60)
	{
		Console.WriteLine("D");
	}
	else if (point>50)
	{
		Console.WriteLine("E");
	}
	else
	{
		Console.WriteLine("Kesildiniz");
	}
}
else
{
	Console.WriteLine("Qiymet duzgun daxil edilmemisdir.");
}