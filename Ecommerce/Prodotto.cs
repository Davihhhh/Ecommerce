using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Prodotto
    {
        private string _id;
        private string _nome;       
        private string _prezzo;
        private string _produttore;
        private string _descrizione;

        public string Id 
        {
            get { return _id; }
            private set { _id = value; }
        }
        public string Nome
        {
            get { return _nome; }   
            private set { _nome = value; }
        }
        public string Descrizione
        {
            get { return _descrizione; }
            private set { _descrizione = value; }
        }
        public string Prezzo
        {
            get { return _prezzo; }
            private set { _prezzo = value; }
        }
        public string Produttore
        {
            get { return _produttore; }
            private set { _produttore = value; }
        }

        public Prodotto(string id, string nome, string descrizione, string prezzo, string produttore)
        {
            Id = id;
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Produttore = produttore;
        }

        
    }
}
