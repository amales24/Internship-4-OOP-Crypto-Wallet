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
            TotalValueBefore = GetAllAssetAddresses().Count != 0 ? GetTotalAssetValue() : 0;
        }

        public double GetMyFungibleAssetValue(Asset myAsset)
        {
            if (!FungibleAssetBalance.Keys.Contains(myAsset.Address))
            {
                Console.WriteLine("Ovaj wallet ne sadrzi trazeni asset");
                return 0;
            }

            return FungibleAssetBalance[myAsset.Address];
        }

        public double GetMyFungibleAssetValueInUSD(Asset myAsset)
        {
            return GetMyFungibleAssetValue(myAsset) * myAsset.Value;
        }

        public void PrintWalletInfo()
        {
            Console.WriteLine($"> Tip walleta: {GetWalletType()} \n" +
            $"> Adresa walleta: {Address} \n" +
            $"> Ukupna vrijednost svih asseta u USD: {(GetAllAssetAddresses().Count != 0 ? GetTotalAssetValue() : "Nema nikakvih asseta!")} \n" +
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

        public virtual List<Guid> GetAllAssetAddresses()
        {
            return FungibleAssetBalance.Keys.ToList();
        }

        public void ChangeAssetBalance(Guid myAssetAddress, double amount)
        {
            if (!SupportedAssets.Contains(myAssetAddress))
                Console.WriteLine("Ovaj asset nije podrzan u ovom novcaniku!");

            else if (!FungibleAssetBalance.Keys.Contains(myAssetAddress) && amount < 0)
                Console.WriteLine("Ovaj asset ne nalazi se u novcaniku!");

            else if (!FungibleAssetBalance.Keys.Contains(myAssetAddress) && amount > 0)
            {
                FungibleAssetBalance.Add(myAssetAddress, amount);
            }
            else
                FungibleAssetBalance[myAssetAddress] += amount;
        }
    }
}
