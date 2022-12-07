using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes
{ 
    public class NonFungibleAsset : Asset
    {
        public Guid FungibleAssetAddress { get; }
        public NonFungibleAsset(Guid fungibleAssetAddress, double value, string name) : base(value, name) 
        {
            FungibleAssetAddress = fungibleAssetAddress;
        }

        public override bool IsFungible()
        {
            return false;
        }

        public double GetValueInUSD()
        {
            var myCurrency = Globals.fungibleAssetsList.Find(a => a.Address == FungibleAssetAddress);

            return Value * myCurrency.Value;
        }

        public override void ChangeAssetValue(double percentage)
        {
            GetMyCurrency().ChangeAssetValue(percentage);
        }

        public FungibleAsset GetMyCurrency()
        {
            return Globals.fungibleAssetsList.Find(a => a.Address == FungibleAssetAddress);
        }
    }
}
