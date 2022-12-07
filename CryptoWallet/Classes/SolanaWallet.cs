using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes
{
    public class SolanaWallet : NonFungibleSupportingWallet
    {
        public SolanaWallet(Dictionary<Guid, double> fungibleAssetBalance, List<Guid> nonFungibleAssetAddresses) : base(Globals.solanaSupported, fungibleAssetBalance, nonFungibleAssetAddresses)
        {
        }

        public override WalletType GetWalletType()
        {
            return WalletType.Solana;
        }
    }
}
