using System;
using System.Collections.Generic;
using System.Linq;

namespace Esercitazione
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Studente> studenti = new List<Studente>
            {
                new Studente {Id = 1, Nome="Valerio", Cognome = "Anedda", Sesso= "M"},
                new Studente {Id = 2, Nome="Lorenzo", Cognome = "Anedda", Sesso= "M"},
                new Studente {Id = 3, Nome="Gabriele", Cognome = "Anedda", Sesso= "M"},
                new Studente {Id = 4, Nome="Giusy", Cognome = "Anedda", Sesso= "F"},
                new Studente {Id = 5, Nome="Francesca", Cognome = "Anedda", Sesso= "F"}
            };

            List<Pasto> pasti = new List<Pasto>
            {
                new Pasto {Id = 1, Nome = "Salumi e formaggi", Tipo = eTipoPasto.Antipasto, Peso = 0.2, ValoreInPunti = 1 },
                new Pasto {Id = 2, Nome = "Caprese", Tipo = eTipoPasto.Antipasto, Peso = 0.2, ValoreInPunti = 1 },
                new Pasto {Id = 3, Nome = "Polpo con patate", Tipo = eTipoPasto.Antipasto, Peso = 0.3, ValoreInPunti = 1 },
                new Pasto {Id = 4, Nome = "Olive", Tipo = eTipoPasto.Antipasto, Peso = 0.1, ValoreInPunti = 1 },
                new Pasto {Id = 5, Nome = "Carbonara", Tipo = eTipoPasto.Primo, Peso = 0.2, ValoreInPunti = 1 },
                new Pasto {Id = 6, Nome = "Spaghetto allo scoglio", Tipo = eTipoPasto.Primo, Peso = 0.2, ValoreInPunti = 1 },
                new Pasto {Id = 7, Nome = "Lasagna", Tipo = eTipoPasto.Primo, Peso = 0.4, ValoreInPunti = 2 },
                new Pasto {Id = 8, Nome = "Fettina ai ferri", Tipo = eTipoPasto.Secondo, Peso = 0.5, ValoreInPunti = 2 },
                new Pasto {Id = 9, Nome = "Hamburger", Tipo = eTipoPasto.Secondo, Peso = 0.5, ValoreInPunti = 2 },
                new Pasto {Id = 10, Nome = "Calamari fritti", Tipo = eTipoPasto.Secondo, Peso = 0.6, ValoreInPunti = 3 },
                new Pasto {Id = 11, Nome = "Cheesecake", Tipo = eTipoPasto.Dolce, Peso = 0.3, ValoreInPunti = 1 },
                new Pasto {Id = 12, Nome = "Macedonia", Tipo = eTipoPasto.Dolce, Peso = 0.3, ValoreInPunti = 2 },
                new Pasto {Id = 13, Nome = "Tiramisù", Tipo = eTipoPasto.Dolce, Peso = 0.3, ValoreInPunti = 1 },
            };

            List<Prenotazione> prenotazioni = new List<Prenotazione>
            {
                new Prenotazione { IdStudente = 1, Data = new DateTime(2021, 03, 01), IdPasto = 1},
                new Prenotazione { IdStudente = 1, Data = new DateTime(2021, 03, 01), IdPasto = 7},
                new Prenotazione { IdStudente = 1, Data = new DateTime(2021, 03, 01), IdPasto = 10},
                new Prenotazione { IdStudente = 1, Data = new DateTime(2021, 03, 01), IdPasto = 13},
                new Prenotazione { IdStudente = 1, Data = new DateTime(2021, 03, 06), IdPasto = 2},
                new Prenotazione { IdStudente = 1, Data = new DateTime(2021, 03, 06), IdPasto = 1},
                new Prenotazione { IdStudente = 1, Data = new DateTime(2021, 03, 06), IdPasto = 9},
                new Prenotazione { IdStudente = 3, Data = new DateTime(2021, 03, 11), IdPasto = 2},
                new Prenotazione { IdStudente = 3, Data = new DateTime(2021, 03, 11), IdPasto = 5},
                new Prenotazione { IdStudente = 3, Data = new DateTime(2021, 03, 11), IdPasto = 10},
                new Prenotazione { IdStudente = 3, Data = new DateTime(2021, 03, 11), IdPasto = 11},
                new Prenotazione { IdStudente = 5, Data = new DateTime(2021, 02, 01), IdPasto = 10},
                new Prenotazione { IdStudente = 5, Data = new DateTime(2021, 02, 01), IdPasto = 13},
                new Prenotazione { IdStudente = 5, Data = new DateTime(2021, 02, 01), IdPasto = 3},
                new Prenotazione { IdStudente = 4, Data = new DateTime(2021, 02, 01), IdPasto = 11},
                new Prenotazione { IdStudente = 4, Data = new DateTime(2021, 02, 01), IdPasto = 7},
                new Prenotazione { IdStudente = 4, Data = new DateTime(2021, 02, 01), IdPasto = 3},
                new Prenotazione { IdStudente = 2, Data = new DateTime(2021, 02, 01), IdPasto = 8},
                new Prenotazione { IdStudente = 2, Data = new DateTime(2021, 02, 01), IdPasto = 4},
                new Prenotazione { IdStudente = 5, Data = new DateTime(2021, 03, 02), IdPasto = 2},
                new Prenotazione { IdStudente = 5, Data = new DateTime(2021, 03, 02), IdPasto = 4},
                new Prenotazione { IdStudente = 1, Data = new DateTime(2021, 03, 02), IdPasto = 9},
            };

            var queryAntipasto = pasti.Where(tipoPasto => tipoPasto.Tipo == eTipoPasto.Antipasto)
                                  .OrderByDescending(e => e.Nome)
                                  .Select(e => e);

            foreach (var pasto in queryAntipasto)
            {
                Console.WriteLine(pasto.Nome);
            }

            var queryPrimo = pasti.Where(tipoPasto => tipoPasto.Tipo == eTipoPasto.Primo)
                                 .OrderByDescending(e => e.Nome)
                                 .Select(e => e);

            foreach (var pasto in queryPrimo)
            {
                Console.WriteLine(pasto.Nome);
            }







        }

    }
}
