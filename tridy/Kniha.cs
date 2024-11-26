using System;

namespace Classy
{
    internal class Kniha
    {
        private string _název;
        private int _cena;
        private string _autor;
        private string _nakladatelství;
        private int _pocetstran;

        public string Název { get => _název; set => _název = value; }
        public int Cena
        {
            get => _cena;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Cena nemůže být záporná.");
                _cena = value;
            }
        }
        public string Autor { get => _autor; set => _autor = value; }
        public string Nakladatelství { get => _nakladatelství; set => _nakladatelství = value; }
        public int Pocetstran
        {
            get => _pocetstran;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Počet stran nemůže být záporný.");
                _pocetstran = value;
            }
        }

        public Kniha(string název, int cena, string autor, string nakladatelství, int pocetstran)
        {
            this._název = název;
            this.Cena = cena; // Používáme vlastnost pro validaci
            this._autor = autor;
            this._nakladatelství = nakladatelství;
            this.Pocetstran = pocetstran; // Používáme vlastnost pro validaci
        }
    }
}
