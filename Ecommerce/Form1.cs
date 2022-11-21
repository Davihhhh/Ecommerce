using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ecommerce
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        //private const string _path = @"./prodotti.csv";
        //private const int _recordLenght = 256;

        private Carrello carrello = new Carrello("aabb", 1000);
        private Carrello prodottiDisponibili = new Carrello("ccdd", 1000);


        private readonly Prodotto prodotto0 = new Prodotto("d4", "trancio", "questo trancio è buonissimo", "150€", "Strada Cosimo il fornaio");
        private readonly Prodotto prodotto1 = new Prodotto("a1", "pane", "questo pane è buonissimo", "200€", "Strada Cosimo il fornaio");
        private readonly Prodotto prodotto2 = new Prodotto("b2", "focaccia", "questa focaccia è buonissima", "300€", "Strada Cosimo il fornaio");
        private readonly Prodotto prodotto3 = new Prodotto("c3", "pizza", "questa pizza è buonissima", "350€", "Strada Cosimo il fornaio");
       
        


        private void Form1_Load(object sender, EventArgs e)
        {
            ProdottiDisponibili();
        }




        private void ProdottiDisponibili()
        {
            prodottiDisponibili.Lista[0] = prodotto0;
            prodottiDisponibili.Lista[1] = prodotto1;
            prodottiDisponibili.Lista[2] = prodotto2;
            prodottiDisponibili.Lista[3] = prodotto3;
        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {

        }

        private void buttonRimuovi_Click(object sender, EventArgs e)
        {

        }
    }
}
