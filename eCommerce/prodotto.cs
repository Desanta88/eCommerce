﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    public class prodotto
    {
        private string _id;
        private string _nome;
        private string _produttore;
        private string _descrizione;
        private float _prezzo;

        public prodotto(string iden, string pro, string name)
        {
            _id = iden;
            _produttore = pro;
            _nome = name;
        }
        public prodotto(string pro, string name)
        {
            _produttore = pro;
            _nome = name;
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Produttore
        {
            get { return _produttore; }
            private set { _produttore = value; }
        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }
        public float Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }
        public override string ToString()
        {
            return Id + ";" + Nome;
        }
    }
}
