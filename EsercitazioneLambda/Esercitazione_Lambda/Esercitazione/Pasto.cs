using System;
using System.Collections;
using System.Collections.Generic;

namespace Esercitazione
{
    class Pasto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public eTipoPasto Tipo { get; set; }
        public double Peso { get; set; }
        public int ValoreInPunti { get; set; }
    }

    enum eTipoPasto
    {
        Antipasto,
        Primo,
        Secondo,
        Dolce
    }
}
