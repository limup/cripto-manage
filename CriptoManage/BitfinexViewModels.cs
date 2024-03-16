using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CriptoManage
{
    public class BitfinexViewModels
    {
        public double MidBitfinex { get; set; }
        public double BidBitfinex { get; set; }
        public double AskBitfinex { get; set; }
        public double LastPriceBitfinex { get; set; }
        public double LowBitfinex { get; set; }
        public double HightBitfinex { get; set; }
        public double VolumeBitfinex { get; set; }
    }
}