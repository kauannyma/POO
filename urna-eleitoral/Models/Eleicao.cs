namespace Models
{
	public class Eleicao
	{
		private int ano;
		private int turno;
		private List<Candidato> candidatos;
		private List<Eleitor> eleitores;
	
		public int Ano
		{
			get { return ano; }
			set { ano = value; }
		}


		public int Turno
		{
			get { return turno; }
			set { turno = value; }
		}
		public List<Candidato> Candidatos
		{
			get { return candidatos; }
			set { candidatos = value; }
		}


		public List<Eleitor> Eleitores
		{
			get { return eleitores; }
			set { eleitores = value; }
		}
		public Eleicao(int _ano, int _turno)
		{
			Ano = _ano;
			Turno = _turno;
		}

	}
}


