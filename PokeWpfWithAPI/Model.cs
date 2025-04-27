using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PokeWpfWithAPI
{
    internal class Model
    {
        public ObservableCollection<Pokemon> PokeList { get; set; }
        public void ReadApi()
        {
            string apiUrl = "https://localhost:7274/api/Poke";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(apiUrl).Result;

                if (response.IsSuccessStatusCode)
                {
                    string responseData = response.Content.ReadAsStringAsync().Result;

                    var json = JArray.Parse(responseData);

                    foreach (var item in json)
                    {
                        int temp = Convert.ToInt32(item["id"]);
                        string id = temp.ToString("D3");
                        string name = item["name"]?.ToString();
                        string type = item["typ"]?.ToString();
                        Pokemon tempPokemon = new Pokemon(id, name, type);
                        tempPokemon.FillImgPath();
                        PokeList.Add(tempPokemon);
                    }
                }
                else
                {
                    throw new Exception($"{response.StatusCode}");
                }
            }
        }

        public Model()
        {
            PokeList = new ObservableCollection<Pokemon>();
            ReadApi();
        }
    }
}
