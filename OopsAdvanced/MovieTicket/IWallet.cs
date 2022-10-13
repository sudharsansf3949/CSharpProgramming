using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicket
{
    public interface IWallet
    {
         double WalletBalance {get;set; }

         double RechargeWallet(double amount);
        
    }
}