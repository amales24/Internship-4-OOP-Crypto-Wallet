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
        public Dictionary<Guid, int> FungibleAssetBalance { get; }
        public List<Guid> SupportedAssets { get; }
        public List<Guid> TransactionAddresses { get; }

        public Wallet(List<Guid> supportedAssets)
        {
            Address = Guid.NewGuid();
            FungibleAssetBalance = new Dictionary<Guid, int>();
            SupportedAssets = supportedAssets;
            TransactionAddresses = new List<Guid>();
        }
    }
}
