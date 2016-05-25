using System;
using System.Collections.Generic;

namespace CodeDojoCorrida
{
	public class CorridasService
	{
		private CorridasService Self;
		private List<Temporada> Temporadas;

		private CorridasService ()
		{
			Temporadas = new List<Temporada> ();
		}

		public static CorridasService GetInstance()
		{
			if (Self == null)
				Self = new CorridasService();
			return Self;
		}

		public void 
	}
}

