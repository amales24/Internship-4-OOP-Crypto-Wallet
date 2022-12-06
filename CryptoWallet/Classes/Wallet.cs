using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes
{
    public abstract class Wallet
    {
        public Guid Address { get;}
        public Dictionary<Guid, double> FungibleAssetBalance { get; }
        public List<Guid> SupportedAssets { get; }
        public List<Guid> TransactionAddresses { get; }
        private double? TotalValueBefore { get; set; }

        public Wallet(List<Guid> supportedAssets, Dictionary<Guid, double> fungibleAssetBalance)
        {
            Address = Guid.NewGuid();
            FungibleAssetBalance = fungibleAssetBalance;
            SupportedAssets = supportedAssets;
            TransactionAddresses = new List<Guid>();
        }

        public abstract WalletType GetWalletType();

        public virtual double GetTotalAssetValue()
        {
            double totalValue = 0;

            foreach (var assetAddress in FungibleAssetBalance.Keys)
            {
                var myAsset = Globals.fungibleAssetsList.Find(a => a.Address == assetAddress);
                totalValue += FungibleAssetBalance[assetAddress] * myAsset.Value;
            }

            return totalValue;
        }

        public double? GetDifferencePercentage()
        {
            if (TotalValueBefore == null)
            {
                TotalValueBefore = GetTotalAssetValue();
                return 0.0;
            }

            var difference = GetTotalAssetValue() - TotalValueBefore;
            var percentage = difference / TotalValueBefore;
            
            return percentage * 100;
        }
    }
}
