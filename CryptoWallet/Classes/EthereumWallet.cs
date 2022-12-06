using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes
{
    public class EthereumWallet : NonFungibleSupportingWallet
    {
        public EthereumWallet(Dictionary<Guid, double> fungibleAssetBalance, List<Guid> nonFungibleAssetAddresses) : base(Globals.ethereumSupported, fungibleAssetBalance, nonFungibleAssetAddresses) 
        {}

        public override WalletType GetWalletType()
        {
            return WalletType.Ethereum;
        }

    }
}
