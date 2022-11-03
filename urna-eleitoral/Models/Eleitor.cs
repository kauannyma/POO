using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Eleitor
    {
		private string nome; 

		public string Nome
		{
			get { return nome; ; }
			set { nome  = value; }
		}
		private string titulo;
		public string Titulo

		{
			get { return titulo; }
			set { titulo = value; }
		}
		private bool votou;

		public bool Votou
		{
			get { return votou; }
			set { votou = value; }

		}
		public Eleitor(string _nome, string _titulo)
		{
			Nome = _nome;
			Titulo = _titulo;
			Votou = false;
			
			
		}
		


	}
}
