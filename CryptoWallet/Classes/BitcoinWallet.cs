using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes
{
    public class BitcoinWallet : Wallet
    {
        public BitcoinWallet(Dictionary<Guid, double> fungibleAssetBalance) : base(Globals.bitcoinSupported, fungibleAssetBalance) 
        {
        }

        public override WalletType GetWalletType()
        {
            return WalletType.Bitcoin;
        }
    }
}
