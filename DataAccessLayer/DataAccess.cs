using Newtonsoft.Json;
using QuickType;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataAccess
    {

        private string Source()
        {
            if (System.IO.File.ReadAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Source.txt")) == "men")
            {
                return "https://world-cup-json-2018.herokuapp.com";
            }
            else
            {
                return "https://worldcup.sfg.io";
            }
        }

        public Task<List<Matches>> GetMatches()
        {
            return Task.Run(() =>
            {
                var restClient = new RestClient($"{Source()}/matches");

                var result = restClient.Execute<Matches>(new RestRequest());

                return JsonConvert.DeserializeObject<List<Matches>>(result.Content);

            });
        }
        
        public Task<List<Matches>> GetMatchesForCountry(string fifaCode)
        {
            return Task.Run(() =>
            {
                var restClient = new RestClient($"{Source()}/matches/country?fifa_code={fifaCode}");

                var result = restClient.Execute<Matches>(new RestRequest());

                return JsonConvert.DeserializeObject<List<Matches>>(result.Content);

            });
        }

        public Task<List<Teams>> GetTeams()
        {
            return Task.Run(() =>
            {
                var restClient = new RestClient($"{Source()}/teams");

                var result = restClient.Execute<Teams>(new RestRequest());

                return JsonConvert.DeserializeObject<List<Teams>>(result.Content);

            });
        }
    }
}
