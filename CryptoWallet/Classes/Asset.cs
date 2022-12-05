﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes
{
    public abstract class Asset
    {
        public Guid Address { get; }
        public string Name { get; set; }
        public double Value { get; protected set; }

        public Asset() 
        { 
            Address = Guid.NewGuid();
        }
    }
}
