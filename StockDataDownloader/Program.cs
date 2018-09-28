using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StockDataDownloader
{
    class Program
    {
        class DownloadStockdata
        {
            const string WebServiceAddress = "https://www.oslobors.no/ob/servlets/excel?type=history";
            const string Columns = "&columns=TIME%2C+BUYER%2C+SELLER%2C+PRICE_CA%2C+VOLUME%2C+TYPE";
            const string Timeformat = "&format[TIME]=dd.mm.YY%20hh:MM:ss";
            const string Priceformat = "&format[PRICE]=%23%2C%23%230.00%23%23%23";
            const string Volumeformat = "&format[VOLUME]=%23%2C%23%230";
            const string Source = "&source=feed.ose.trades.INSTRUMENTS";
            public string Exchange;
            public string Ticker;


            public void Download()
            {

                string filter = "ITEM_SECTOR%3D%3Ds" + Ticker + Exhange + "%26%26DELETED!%3Dn1&stop=now&start=1537912800000&ascending=true";
            }

            
        }
        static void Main(string[] args)
        {
        }
    }
}
