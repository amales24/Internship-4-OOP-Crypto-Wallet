using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes
{
    public static class Globals
    {
        public static List<FungibleAsset> fungibleAssetsList;
        public static List<NonFungibleAsset> nonFungibleAssetsList;
        public static List<Guid> bitcoinSupported;
        public static List<Guid> ethereumSupported;
        public static List<Guid> solanaSupported;
        public static List<Wallet> walletsList;
    }
}
