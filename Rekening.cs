﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Rekening
    {
        private decimal saldo;
        public void Storten(decimal bedrag)
        {
            saldo += bedrag;
        }
        public decimal Saldo
        {
            get
            {
                return saldo;
            }
        }
    }
}
