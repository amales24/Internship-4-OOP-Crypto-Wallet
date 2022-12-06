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
                totalValue += GetMyFungibleAssetValueInUSD(myAsset);
            }

            return totalValue;
        }

        public double? GetDifferencePercentage()
        {
            if (TotalValueBefore == null)
            {
                SetValueBefore();
                return 0;
            }

            var difference = GetTotalAssetValue() - TotalValueBefore;
            var percentage = difference / TotalValueBefore;
            
            return percentage * 100;
        }

        public void SetValueBefore()
        {
            TotalValueBefore = GetTotalAssetValue();
        }

        public double? GetValueBefore()
        {
            return TotalValueBefore;
        }

        public double GetMyFungibleAssetValueInUSD(Asset myAsset)
        {
            if (!FungibleAssetBalance.Keys.Contains(myAsset.Address))
            {
                Console.WriteLine("Ovaj wallet ne sadrzi trazeni asset");
                return 0;
            }

            return FungibleAssetBalance[myAsset.Address] * myAsset.Value;
        }

        public void PrintWalletInfo()
        {
            Console.WriteLine($"> Tip walleta: {GetWalletType()} \n" +
            $"> Adresa walleta: {Address} \n" +
            $"> Ukupna vrijednost svih asseta u USD: {(GetTotalAssetValue() != 0 ? GetTotalAssetValue() : "Nema nikakvih asseta!")} \n" +
            $"> Postotak pada/povecanja ukupne USD vrijednosti: {GetDifferencePercentage()} % \n");
        }

        public virtual void PrintPortfolio()
        {
            Console.WriteLine($"> Ukupna vrijednost svih asseta u USD: {GetTotalAssetValue()} \n" +
                               "> Popis svih asseta: \n");

            foreach (var fungibleAssetAddress in FungibleAssetBalance)
            {
                var myAsset = Globals.fungibleAssetsList.Find(a => a.Address == fungibleAssetAddress.Key);

                Console.WriteLine($"> Adresa: {fungibleAssetAddress.Key} \n" +
                    $"> Ime: {myAsset.Name} \n" +
                    $"> Oznaka: {myAsset.Label} \n" +
                    $"> Vrijednost u fungible assetu: {fungibleAssetAddress.Value} \n" +
                    $"> Ukupna vrijednost u USD: {GetMyFungibleAssetValueInUSD(myAsset)} \n" +
                    $"> Postotak pada/povecanja ukupne USD vrijednosti: \n");
            }
        }
    }
}
