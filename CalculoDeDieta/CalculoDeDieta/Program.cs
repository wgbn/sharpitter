using System;

namespace CalculoDeDieta
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Alimento aveia = new Alimento ("Aveia em Flocos", 13.9f, 66.6f, 8.5f, 100f);
			Alimento banana = new Alimento ("Banana da Terra", 1.4f, 33.7f, 0.2f, 100f);

			aveia.CalcularCaloria ();
			banana.CalcularCaloria ();

			Console.WriteLine (aveia.ToString ());
			Console.WriteLine ("-------------------------");
			Console.WriteLine (banana.ToString ());
			Console.WriteLine ("-------------------------");
		}
	}
}
