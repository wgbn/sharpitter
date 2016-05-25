using System;
using System.Collections.Generic;

namespace CodeDojoCorrida
{
	public class Piloto
	{
		public string Nome { get; set; }
		public int Posicao { get; set; }
	}

	public class Corrida 
	{
		public List<Piloto> Colocacoes { get; set; }
	}

	public class Temporada 
	{
		public List<Corrida> Corridas { get; set; }
	}
}