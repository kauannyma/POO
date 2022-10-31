﻿namespace Models
{
    public class Carro
    {
        private int velocidadeAtual;
        private string marca;
        private string modelo;
        private int odometro;
        private double tanque;
        private bool ligado;
        private Pneu pneuDianteiroEsquerdo;
        private Pneu pneuDianteiroDireito;
        private Pneu pneuTrazeiroEsquerdo;
        private Pneu pneuTrazeiroDireito;
        public Pneu PneuTrazeiroDireito
        {
            get { return pneuTrazeiroDireito; }
            set
            {
                if (VelocidadeAtual == 0)
                    pneuTrazeiroDireito = value;
                else
                    Console.WriteLine("Voçê vai trocar o pneu em movimento ?");
            }
        }
        public Pneu PneuTrazeiroEsquerdo
        {
            get { return pneuTrazeiroEsquerdo; }
            set
            {
                if (VelocidadeAtual == 0)
                    pneuTrazeiroEsquerdo = value;
                else
                    Console.WriteLine("Voçê vai trocar o pneu em movimento ?");
            }
        }
        public Pneu PneuDianteiroDireito
        {
            get { return pneuDianteiroDireito; }
            set
            {

                if (VelocidadeAtual == 0)
                    pneuDianteiroDireito = value;
                else
                    Console.WriteLine("Voçê vai trocar o pneu em movimento ?");
            }
        }
        public Pneu PneuDianteiroEsquerdo
        {
            get { return pneuDianteiroEsquerdo; }
            set
            {
                if (VelocidadeAtual == 0)
                    pneuDianteiroEsquerdo = value;
                else
                    Console.WriteLine("Voçê vai trocar o pneu em movimento ?");
            }
        }
        public bool Ligado
        {
            get { return ligado; }
            set { ligado = value; }
        }
        public double Tanque
        {
            get { return tanque; }
            set
            {
                if (value == 0)
                    LigarDesligar();
                tanque = value;
            }
        }
        public int Odometro
        {
            get { return odometro; }
            set { odometro = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public int VelocidadeAtual
        {
            get { return velocidadeAtual; }
            set { velocidadeAtual = value; }
        }
        public Carro(string marca, string modelo)
        {
            VelocidadeAtual = 0;
            Marca = marca;
            Modelo = modelo;
            this.odometro = 0;
            Tanque = 5;
            Ligado = false;
            PneuDianteiroEsquerdo = new Pneu(16, "Pirelli");
            PneuDianteiroDireito = new Pneu(16, "Pirelli");
            PneuTrazeiroEsquerdo = new Pneu(16, "Pirelli");
            PneuTrazeiroDireito = new Pneu(16, "Pirelli");
        }
        public void LigarDesligar()
        {
            Ligado = !Ligado;
            if (!Ligado)
                Frear(VelocidadeAtual);
            else if (Tanque == 0)
                LigarDesligar();
        }
        public void Acelerar(int _impulso)
        {
            if (!Ligado)
                return;

            if (tanque == 0)
                LigarDesligar();

            GastarCombustivel(_impulso / 100.0);
            if (Ligado)
            {
                VelocidadeAtual += _impulso;
                PneuDianteiroDireito.Girar(_impulso);
                PneuDianteiroEsquerdo.Girar(_impulso);
                PneuTrazeiroDireito.Girar(_impulso);
                PneuTrazeiroEsquerdo.Girar(_impulso);

                if (PneuDianteiroDireito.Estourado || PneuDianteiroEsquerdo.Estourado ||
                    PneuTrazeiroDireito.Estourado || PneuTrazeiroEsquerdo.Estourado)
                    Frear(VelocidadeAtual);
            }
        }
        public void Frear(int _abatimento)
        {
            VelocidadeAtual -= _abatimento;
            if (VelocidadeAtual < 0)
                VelocidadeAtual = 0;

            PneuDianteiroDireito.Frear(_abatimento);
            PneuDianteiroEsquerdo.Frear(_abatimento);
            PneuTrazeiroDireito.Frear(_abatimento);
            PneuTrazeiroEsquerdo.Frear(_abatimento);
        }
        public void GastarCombustivel(double _fracao)
        {
            Tanque -= _fracao;
            if (Tanque < 0)
                Tanque = 0;
        }
        public void Exibir()
        {
            Console.WriteLine("Velocidade atual: " + VelocidadeAtual);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Odometro: " + Odometro);
            Console.WriteLine("Tanque: " + Tanque);
            Console.WriteLine("Ligado: " + Ligado);
            Console.WriteLine("Pneu dianteiro esquerdo: ");
            pneuDianteiroEsquerdo.Exibir();
            Console.WriteLine("Pneu dianteiro direito: ");
            PneuDianteiroDireito.Exibir();
            Console.WriteLine("Pneu trazeiro esquerdo: ");
            PneuTrazeiroEsquerdo.Exibir();
            Console.WriteLine("Pneu trazeiro direito: ");
            PneuTrazeiroDireito.Exibir();
        }

        public void Abastecer(double _quantidade)
        {
            Tanque += _quantidade;
        }
    }
}






