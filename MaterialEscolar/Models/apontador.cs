using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   internal  class Apontador 
    { 
    
        private string amolado;
        
        private string cor;
        private string marca;
        private int duracao;

    



    public string Cor
        { 
    get { return cor;}
    set { cor = value;}
        }

    public string  Amolado
    {
    get { return amolado; }
    set { amolado = value; }
    }

    public string Marca
    {
    get { return marca; }
    set { marca = value; }
    }
        public int Duracao
        {
            get { return duracao; }
            set { duracao = value; }
        }

    public Apontador (string _amolado, string _apontar)
        { 

            Marca = "volk";
            Amolado = _amolado;
            Cor = "Vermelho";
            duracao = 100; 

        }
        public void _amolado()
        {
            if (duracao > 5) ;
            {
                Console.WriteLine("Apontador amolado !");
            }
            if (duracao < 5) ;
            {
                duracao = 100;
            }
        }
    }
}
