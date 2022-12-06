using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes
{
    public class SolanaWallet : Wallet
    {
        public List<Guid> NonFungibleAssetAddresses { get; }
        public SolanaWallet(Dictionary<Guid, double> fungibleAssetBalance, List<Guid> nonFungibleAssetAddresses) : base(Globals.solanaSupported, fungibleAssetBalance) 
        {
            NonFungibleAssetAddresses = nonFungibleAssetAddresses;
        }

        public override WalletType GetWalletType()
        {
            return WalletType.Solana;
        }

        public override double GetTotalAssetValue()
        {
            double totalNonFungibleValue = 0;

            foreach (var assetAddress in NonFungibleAssetAddresses)
            {
                var myAsset = Globals.nonFungibleAssetsList.Find(a => a.Address == assetAddress);
                var myCurrency = Globals.fungibleAssetsList.Find(a => a.Address == myAsset.FungibleAssetAddress);
                totalNonFungibleValue += myAsset.Value * myCurrency.Value;
            }

            return totalNonFungibleValue + base.GetTotalAssetValue();
        }
    }
}
