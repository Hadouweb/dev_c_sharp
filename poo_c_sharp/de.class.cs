using System;

public static class De
{
	private static Random random = new Random();

	public static int LanceLeDe()
	{
		return random.Next(1, 7);
	}

	public static int LanceLeDe(int max)
	{
		return random.Next(1, max);
	}
}