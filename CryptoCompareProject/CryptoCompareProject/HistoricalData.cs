using System.Collections.Generic;

namespace CryptoCompareProject
{
    public class HistoricalData
    {
        // 1er niveau de profondeur de la Structure Json 
        public class DataRoot {
            public string Response {get; set; }
            public string Type {get; set; }
            public bool Aggregated{get; set; }
            public JsonData Data {get; set;}
        }

        // 2ème niveau de profondeur de la Structure Json 
        public class JsonData  {
            public IList<HistoricalCrypto> Data {get; set;}
        }
    
        // 3ème niveau de profondeur de la Structure Json 

        public class HistoricalCrypto
        {
            public string time; 
            public float high;
            public float low;
            public float open;
            public float volumefrom;
            public float volumeto;
            public float close;
        }
    }
}