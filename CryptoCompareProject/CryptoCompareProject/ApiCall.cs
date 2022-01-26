using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace CryptoCompareProject
{
    public class ApiCall
    {
        public string ApiCallJSON(string address)
        {
            WebClient webClient = new WebClient();
            var jsonString = webClient.DownloadString(address);
            return jsonString;
        }

        public HistoricalData.DataRoot HistoricalDataStorage(string jsonString)
        {
            return JsonConvert.DeserializeObject<HistoricalData.DataRoot>(jsonString);
        }

        public List<double> ClosePriceList(HistoricalData.DataRoot historicalDataStorage)
        {
            List<double> closesList = new List<double>();
            
            for (int i = 0; i < historicalDataStorage.Data.Data.Count; i++)
            {
                closesList.Add(historicalDataStorage.Data.Data[i].close);
            }
            
            return closesList;
        }
    }
}