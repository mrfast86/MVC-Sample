using EventfulSearch.Data.DataEntities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EventfulSearch.Data
{
    internal class GeoCodeData : IGeoCodeData
    {
        public async Task<RootObject> GetLocationAsync(string address)
        {
            string apiKey = ConfigurationManager.AppSettings["GeoCodeAppKey"];
            string url = ConfigurationManager.AppSettings["GeoCodeURL"] + "?address={0}&sensor=false&key={1}";
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(string.Format(url, Uri.EscapeDataString(address), apiKey));
            string result = await response.Content.ReadAsStringAsync();
            RootObject root = JsonConvert.DeserializeObject<RootObject>(result);
            return root;
        }
    }
}
