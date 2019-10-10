﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class PrikazNastavnika
    {
        public class Row
        {
            public int NastavnikID { get; set; }
            public int SkolaID { get; set; }
            public string Skola { get; set; }
            public string Nastavnik { get; set; }
        }
        public List<Row> Nastavnici { get; set; }
    }
}
