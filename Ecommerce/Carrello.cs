using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Carrello
    {
        private string _id;
        private Prodotto[] _lista;
        private int _contatore;
        private int _limiteCarrello;
        

        public string Id
        {
            get { return _id; }
            private set { _id = value; }
        }
        public int Contatore
        {
            get { return _contatore; }
            private set { _contatore = value; }
        }
        public int LimiteCarrello
        {
            get { return _limiteCarrello; }
            private set { _limiteCarrello = value; }
        }
        public Prodotto[] Lista
        { 
            get { return _lista; }
            private set { _lista = value; }
        }
        
       
        public Carrello(string id)
        {
            LimiteCarrello = 1000;
            Id = id;
            Lista = new Prodotto[LimiteCarrello];
            Contatore = 0;
            
        }
        public Carrello(string id, int limiteCarrello)
        {
            LimiteCarrello = limiteCarrello;
            Id = id;
            Lista = new Prodotto[LimiteCarrello];
            Contatore = 0;
            
        }


        public void AggiungiProdotto(Prodotto p)
        {
            if (Contatore >= LimiteCarrello || p == null)
            {
                throw new Exception();
            }
            else
            {
                Lista[Contatore] = p;
                Contatore++;
            }
        }
        public Prodotto RimuoviProdotto(Prodotto p)
        {
            if (Contatore <= 0)
            {
                throw new Exception();
            }
            else
            {
                int pos = RicercaProdotto(p);
                if(pos < 0)
                {
                    throw new Exception();
                }
                else
                {
                    Ricompattazione(pos);
                    return p;
                }
            }
        }
        public Prodotto[] Svuota()
        {
            Prodotto[] value = Lista;
            Lista = new Prodotto[1000];
            return value;
        }


        private int RicercaProdotto(Prodotto p)
        {
            int pos = -1;
            for (int a = 0; a < Contatore; a++)
            {
                if(Lista[a] == p)
                {
                    pos = a;
                    return pos;
                }
            }
            return pos;
        }
        private void Ricompattazione(int pos)
        {
            for (int a = pos; a < Contatore; a++) 
            {
                Lista[a] = Lista[a + 1];
            }
        }    
    }
}
