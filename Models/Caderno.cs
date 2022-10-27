using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Models
{
    public class Caderno
    {
        private string marca;
        private int quantidadedeFolha;
        private int quantidadedeMateria;
        private string cor;
        private bool aberto;



        public int QuantidadedeFolha
        {
            get { return quantidadedeFolha; }
            set { quantidadedeFolha = value; }
        }


        public int QuantidadedeMateria
        {
            get { return quantidadedeMateria; }
            set { quantidadedeMateria = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public bool Aberto
        {
            get { return aberto; }
            set { aberto = value; }
        }

        public Caderno(string _marca, string _cor)
        {
            Marca = _marca;
            Cor = _cor;
            quantidadedeFolha = 200;
            aberto = false;




        }
        public void Abrir()
        {
            Aberto = true;

        }

        public void Fechar()
        {
            Aberto = false;
        }
        public void arrancarPágina()
        {
            if (QuantidadedeFolha > 0)
            {

            }

            quantidadedeFolha -= 1;
        }
    }
}

      
    

