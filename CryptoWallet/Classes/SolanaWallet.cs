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
        public SolanaWallet(List<Guid> supportedAssets) : base(supportedAssets) { }
    }
}
