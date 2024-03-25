using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate;

public class CurrencyExchangeMonitor
{
    public delegate void PriceChange(int currentPrice);

    public PriceChange PriceChangeHandler { get; set; }

    public void Start()
    {
        while (true)
        {
            int currentPrice = new Random().Next(100);

            PriceChangeHandler(currentPrice);

            Thread.Sleep(2000);
        }
    }
}