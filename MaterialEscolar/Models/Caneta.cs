namespace Models
{
    public class Caneta
    {
		private string cor;
		private string marca;
		private int percentualCarga;
		private string material;
		private bool estourada;
		private bool caida;
		private bool tampada;

		public string Cor
		{
			get { return cor; }
			set { cor = value; }
		}
		public string Marca
		{
			get { return marca; }
			set { marca = value; }
		}
		public int PercentualCarga
		{
			get { return percentualCarga; }
			set { percentualCarga = value; }
		}
		public string Material
		{
			get { return material; }
			set { material = value; }
		}
		public bool Estourada
		{
			get { return estourada; }
			set { estourada = value; }
		}

		public bool Caida
		{
			get { return caida; }
			set { caida = value; }
		}

		public bool Tampada
		{
			get { return tampada; }
			set { tampada = value; }
		}

		public Caneta(string _cor, string _marca, string _material)
		{
			Cor = _cor;
			Marca = _marca;
			PercentualCarga = 100;
			Material = _material;			
		}
		
		public void Tampar()
		{
			Tampada = true;
		}
		public void Destampar()
		{
			Tampada = false;
		}

		public void Escrever(string _texto)
		{
			if (Tampada)
			{
				Console.WriteLine("A caneta está tampada.");
				return;
			}
			if (Caida)
			{
				Console.Write("Pegue a caneta do chão");
				return;
			}
			if (Estourada)
			{
				Console.WriteLine("A caneta está esourada. :(");
				return;
			}
			Console.WriteLine(_texto);
			GastarTinta();
		}

		private void GastarTinta()
		{
			PercentualCarga -= 10;
		}

		public void Exibir()
		{
			Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("% de carga: " + PercentualCarga);
            Console.WriteLine("Tampada: " + Tampada);
        }
	}
}