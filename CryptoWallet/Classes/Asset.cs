using System;
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
        public Asset(double value, string name) 
        { 
            Address = Guid.NewGuid();
            Value = value;
            Name = name;
        }

        public abstract bool IsFungible();

        public abstract void ChangeAssetValue(double percentage);

    }
}
