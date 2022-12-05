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
        public EthereumWallet(List<Guid> supportedAssets) : base(supportedAssets) { }
    }
}
