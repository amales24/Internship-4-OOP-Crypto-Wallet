using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes
{
    public abstract class Transaction
    {
        public Guid Id { get; }
        public Guid AssetAddress { get; }
        public DateTime DateOfTransaction { get; }
        public Guid SenderWalletAddress { get; }
        public Guid RecipientWalletAddress { get; }
        public bool IsRevoked { get; set; }

        public Transaction(Guid assetAddress, Guid senderWalletAddress, Guid recipientWalletAddress)
        {
            Id = Guid.NewGuid();
            AssetAddress = assetAddress;
            DateOfTransaction = DateTime.Now;
            SenderWalletAddress = senderWalletAddress; 
            RecipientWalletAddress = recipientWalletAddress;
            IsRevoked = false;
        }

        public abstract bool IsFungible();
    }
}
