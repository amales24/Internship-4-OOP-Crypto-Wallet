using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes
{
    public class FungibleTransaction : Transaction
    {
        public double StartBalanceOfSender { get; set; }
        public double EndBalanceOfSender { get; set; }
        public double StartBalanceOfRecipient { get; set; }
        public double EndBalanceOfRecipient { get; set; }
        public FungibleTransaction(Guid assetAddress, Guid senderWalletAddress, Guid recipientWalletAddress) : base(assetAddress, senderWalletAddress, recipientWalletAddress)
        {          
        }

        public override bool IsFungible()
        {
            return true;
        }
    }
}
