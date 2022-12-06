using System;
using System.Collections;
using System.Collections.Generic;

namespace Esercitazione
{
    class Studente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Sesso { get; set; }

        public List<Prenotazione> Ordini { get; set; }
    }
}
