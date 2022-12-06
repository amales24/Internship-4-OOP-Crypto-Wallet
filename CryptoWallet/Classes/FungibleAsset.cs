using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes
{
    public class FungibleAsset : Asset
    {
        public string Label { get; set; }
        public FungibleAsset(double value, string name, string label) : base(value, name) 
        {
            Label = label;
        }

        public override bool IsFungible()
        {
            return true;
        }
    }
}
