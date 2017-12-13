using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventfulSearch.Data.DataEntities;
using System.Configuration;
using System.Xml.Serialization;
using System.IO;
using System.Net.Http;
using EventfulSearch.Common.Entities;

namespace EventfulSearch.Data
{
    internal class EventfulSearchData : IEventfulSearchData
    {
        public async Task<search> SearchAsync(SearchParam param)
        {
            string apiKey = ConfigurationManager.AppSettings["EventfulAppKey"];
            string url = ConfigurationManager.AppSettings["EventfulURL"] + "?where={0},{1}&within={2}&date={3}&category={4}&app_key={5}&page_size=500";
            HttpClient client = new HttpClient();
            string dateFormatted = param.StartDate.ToString("yyyyMMdd") + "00-" + param.EndDate.ToString("yyyyMMdd") + "00";
            var response = await client.GetAsync(string.Format(url, param.Lat, param.Long, param.Radius.ToString(), dateFormatted, param.Category, apiKey));
            string result = await response.Content.ReadAsStringAsync();
            var buffer = Encoding.UTF8.GetBytes(result);
            using (var stream = new MemoryStream(buffer))
            {
                var serializer = new XmlSerializer(typeof(search));
                var eventfulSearchObject = (search)serializer.Deserialize(stream);
                return eventfulSearchObject;
            }
        }
    }
}
