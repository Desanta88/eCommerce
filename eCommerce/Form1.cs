namespace eCommerce
{
    public partial class Form1 : Form
    {
        public prodotto product1;
        public prodotto product2;
        public prodotto product3;
        public prodotto[] prodottiPre = new prodotto[3];
        public prodotto[] Prodotti = new prodotto[100];
        public carrello car = new carrello("dfasij");
        public string prodottoSelect,sss;
        public int nP = 0,npC;
        public Form1()
        {
            InitializeComponent();
            product1 = new prodotto("sadw", "AIA", "cotoletta");
            prodottiPre[0] = product1;
            product2 = new prodotto("sfjf", "logitech", "mouse wireless");
            prodottiPre[1] = product2;
            product3 = new prodotto("ciao", "porcocane", "carne di maiale");
            prodottiPre[2] = product3;
            prodottoPredefiniti(prodottiPre);
        }

        public void prodottoPredefiniti(prodotto[] p)
        {
            for(int i = 0; i < 3; i++)
            {
                ListViewItem A = new ListViewItem(p[i].Nome);
                listViewProdotti.Items.Add(A);
            }
            
     
        }
        public void MettiNelCarrello(string s,prodotto[] p)
        {
      
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            prodottoSelect = listViewProdotti.SelectedItems[0].Text;
            ListViewItem B = new ListViewItem(prodottoSelect);
            listViewCarrello.Items.Add(B);
            if (nP < 100)
            {
                

            }
        }
    }
}