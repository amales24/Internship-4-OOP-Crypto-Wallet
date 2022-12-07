using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes
{
    public class NonFungibleTransaction : Transaction
    {
        public NonFungibleTransaction(Guid assetAddress, DateTime dateOfTransaction, Guid senderWalletAddress, Guid recipientWalletAddress) : base(assetAddress, dateOfTransaction, senderWalletAddress, recipientWalletAddress)
        { 
        }

        public override bool IsFungible()
        {
            return false;
        }
    }
}
