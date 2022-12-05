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
        public NonFungibleAsset(Guid fungibleAssetAddress) : base() 
        {
            FungibleAssetAddress = fungibleAssetAddress;
        }
    }
}
