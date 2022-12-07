using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes
{
    public abstract class NonFungibleSupportingWallet : Wallet
    {
        public List<Guid> NonFungibleAssetAddresses { get; }
        public NonFungibleSupportingWallet(List<Guid> supportedAssets, Dictionary<Guid, double> fungibleAssetBalance, List<Guid> nonFungibleAssetAddresses) : base(supportedAssets, fungibleAssetBalance)
        {
            NonFungibleAssetAddresses = nonFungibleAssetAddresses;
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

        public override void PrintPortfolio()
        {
            base.PrintPortfolio();

            foreach (var myNonFungibleAddress in NonFungibleAssetAddresses)
            {
                var myAsset = Globals.nonFungibleAssetsList.Find(a => a.Address == myNonFungibleAddress);
                var myCurrency = Globals.fungibleAssetsList.Find(a => a.Address == myAsset.FungibleAssetAddress);

                Console.WriteLine($"> Adresa: {myNonFungibleAddress} \n" +
                    $"> Ime: {myAsset.Name} \n" +
                    $"> Vrijednost u fungible assetu: {myAsset.Value} {myCurrency.Label}\n" +
                    $"> Ukupna vrijednost u USD: {myAsset.GetValueInUSD()} \n" +
                    $"> Postotak pada/povecanja ukupne USD vrijednosti: % \n");

                //SetAssetValueBefore(myAsset);
            }
        }

        public override List<Guid> GetAllAssetAddresses()
        {
            var myAssets = base.GetAllAssetAddresses();

            foreach (var assetAddress in NonFungibleAssetAddresses)
                myAssets.Add(assetAddress);

            return myAssets;
        }

        public bool RemoveNonFungibleAsset(Guid myAssetAddress)
        {
            if (!NonFungibleAssetAddresses.Contains(myAssetAddress))
            {
                Console.WriteLine("Ovaj asset ne nalazi se u novcaniku!");
                return false;
            }
            NonFungibleAssetAddresses.Remove(myAssetAddress);

            return true;
        }

        public bool AddNonFungibleAsset(Guid myAssetAddress)
        {
            if (NonFungibleAssetAddresses.Contains(myAssetAddress))
            {
                Console.WriteLine("Ovaj asset vec se nalazi u novcaniku!");
                return false;
            }

            NonFungibleAssetAddresses.Add(myAssetAddress);

            return true;
        }

        public override void SetAssetValueBefore(Asset myAsset)
        {
            base.SetAssetValueBefore(myAsset);

            if(AssetValuesBefore.ContainsKey(myAsset.Address) && !myAsset.IsFungible())
            {
                NonFungibleAsset myNonFungibleAsset = (NonFungibleAsset)myAsset;
                AssetValuesBefore[myAsset.Address] = myNonFungibleAsset.GetValueInUSD();
            }
            else
            {
                NonFungibleAsset myNonFungibleAsset = (NonFungibleAsset)myAsset;
                AssetValuesBefore.Add(myAsset.Address, myNonFungibleAsset.GetValueInUSD());
            }
        }

        public override double GetAssetDifferencePercentage(Asset myAsset)
        {
            var percentage = base.GetAssetDifferencePercentage(myAsset);
            double difference;

            if (!myAsset.IsFungible())
            {
                NonFungibleAsset myNonFungibleAsset = (NonFungibleAsset)myAsset;
                difference = myNonFungibleAsset.GetValueInUSD() - AssetValuesBefore[myAsset.Address];
                percentage = difference / AssetValuesBefore[myAsset.Address];
            }

            return percentage;
        }
    }
}
