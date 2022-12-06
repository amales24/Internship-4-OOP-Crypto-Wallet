using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes
{
    public class EthereumWallet : Wallet
    {
        public List<Guid> NonFungibleAssetAddresses { get; }
        public EthereumWallet(Dictionary<Guid, double> fungibleAssetBalance, List<Guid> nonFungibleAssetAddresses) : base(Globals.ethereumSupported, fungibleAssetBalance) 
        {
            NonFungibleAssetAddresses = nonFungibleAssetAddresses;
        }

        public override WalletType GetWalletType()
        {
            return WalletType.Ethereum;
        }

        public override double GetTotalAssetValue()
        {
            double totalNonFungibleValue = 0;

            foreach (var assetAddress in NonFungibleAssetAddresses)
            {
                var myAsset = Globals.nonFungibleAssetsList.Find(a => a.Address == assetAddress);
                totalNonFungibleValue += myAsset.GetValueInUSD();
            }

            return totalNonFungibleValue + base.GetTotalAssetValue();
        }
    }
}
