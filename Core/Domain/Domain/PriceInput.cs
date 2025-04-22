using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PriceInput
    {
        public double GoldOuncePrice { get; set; } // قیمت انس طلا (دلار)
        public double SilverOuncePrice { get; set; } // قیمت انس نقره (دلار)
        public double DollarPrice { get; set; } // قیمت دلار (تومان)
        public double OunceToGram { get; set; } = 31.1035;
        public double CoinGoldWeight { get; set; } = 7.322382;
        public int CoinMintFee { get; set; } = 2000000;
    }
}
