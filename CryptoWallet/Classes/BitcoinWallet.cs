using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes
{
    public class BitcoinWallet : Wallet
    {
        public BitcoinWallet(List<Guid> supportedAssests) : base(supportedAssests) { }
    }
}
