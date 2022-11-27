using System;
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

        public prodotto(string iden, string pro,string name,string des,float price)
        {
            _id = iden;
            _produttore = pro;
            _nome = name;
            _descrizione = des;
            _prezzo = price;
        }
        public prodotto() : this("xxxxx", "xxxxx", "xxxxx", "xxxxx",10)
        {

        }
        public prodotto(string iden, string pro, string name) : this(iden,pro,name,"xxxxx",10)
        {

        }
        public prodotto(string iden, string pro, string name,string des) : this(iden, pro, name,des,10)
        {

        }
        public prodotto(string iden, string pro, string name, float price) : this(iden, pro, name,"xxxxx", 10)
        {

        }
        public  string Id
        {
            get { return _id;}
            private set { _id = value;}
        }
        public string Produttore
        {
            get { return _produttore;}
            private set { _produttore = value;}
        }
        public string Nome
        {
            get { return _nome;}
            set { _nome = value;}
        }
        public string Descrizione
        {
            get { return _descrizione;}
            set { _descrizione = value;}
        }
        public float Prezzo
        {
            get { return _prezzo;} 
            set { _prezzo = value;}
        }
        private bool Equals(prodotto p)
        {
            if (p == null)
                return false;
            if (this == p)
                return true;
            return (this.Id == p.Id);
        }
    }
}
