using Casascius.Bitcoin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.Bitcoin
{
    public class BitcoinFacade
    {
        public static bool IsValidWalletAddress(string walletAddr)
        {
            byte[] hex = BtcAddressUtil.Base58CheckToByteArray(walletAddr);
            if (hex == null || hex.Length != 21)
                return false;
            else
                return true;
        }
    }
}
