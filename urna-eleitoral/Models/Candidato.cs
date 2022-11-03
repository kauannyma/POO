using System.Security.Cryptography.X509Certificates;

namespace Models
{
    public class Candidato
    {

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }


        public Candidato(string _nome, int _numero)
        {

            Nome = _nome;
            Numero = _numero;
           

        }
       
        
    }
}
