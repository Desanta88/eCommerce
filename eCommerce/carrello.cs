using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    public class carrello
    {
        private string _id;
        private prodotto[] Prodotti;
        private int a = 0, pos = 0,duplicati=0;
        

        public carrello(string iden)
        {
            _id = iden;
            Prodotti = new prodotto[100];
        }
        public int NProdotti
        {
            get { return a; }
        }
        public string Id
        {
            get { return _id;}
            private set { _id = value;}
        }
        public void Aggiungi(prodotto p)
        {
            if (a < 100 && p!=null)
            {
                Prodotti[a] = p;
                a++;
            }
        }
        private int Esiste(prodotto p)
        {
           for(int i = 0; i < a; i++)
           {
              if (p!=null && Prodotti[i].Equals(p))
                   return i;
           }
           return -1;
        }
        private void Ricompatta(int posi)
        {
            for(int i = posi; i < a-1; i++)
            {
                Prodotti[i]= Prodotti[i+1];
            }
            a--;
        }
        public void Rimuovi(prodotto p)
        {
            pos = Esiste(p);
            if(pos!=-1)
              Ricompatta(pos);
        }
        public void Svuota()
        {
            for (int i = 0; i < a; i++)
            {
                Prodotti[i] = null;
                a--;
            }
        }
        public prodotto[] GetProdotti()
        {
            return Prodotti;
        }
        public int getDuplicati()
        {
            return duplicati;
        }
    }
}
