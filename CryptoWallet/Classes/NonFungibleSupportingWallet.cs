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
                    $"> Postotak pada/povecanja ukupne USD vrijednosti:  % \n");
            }
        }

        public override List<Guid> GetAllAssetAddresses()
        {
            var myAssets = base.GetAllAssetAddresses();

            foreach (var assetAddress in NonFungibleAssetAddresses)
                myAssets.Add(assetAddress);

            return myAssets;
        }

        public void RemoveNonFungibleAsset(Guid myAssetAddress)
        {
            if (!NonFungibleAssetAddresses.Contains(myAssetAddress))
            {
                Console.WriteLine("Ovaj asset ne nalazi se u novcaniku!");
                return;
            }
            NonFungibleAssetAddresses.Remove(myAssetAddress);

            return;
        }

        public void AddNonFungibleAsset(Guid myAssetAddress)
        {
            if (NonFungibleAssetAddresses.Contains(myAssetAddress))
            {
                Console.WriteLine("Ovaj asset vec se nalazi u novcaniku!");
                return;
            }

            if (!SupportedAssets.Contains(myAssetAddress)) 
            {
                Console.WriteLine("Ovaj asset nije podrzan u novcaniku!");
                return;
            }
            NonFungibleAssetAddresses.Add(myAssetAddress);

            return;
        }       
    }
}
