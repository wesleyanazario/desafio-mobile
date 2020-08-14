using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

//Classe de acesso a API
namespace Vitreo.Layers.Service
{
    public class PersonService
    {

        public PersonService()
        {

        }

        //Metodo de retorno dos dados, faz a conexao e o get no service da MArvel [API]
        public Model.CharacterDataWrapper GetPersonList(String _filter)
        {

            var key = new Model.KeysApi();

            var uri = "https://gateway.marvel.com:443/v1/public/characters?nameStartsWith=" + _filter + "&ts=" + key.Time + "&apikey=" + key.ApiKey + "&hash=" + key.Hash;

            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            var resposta = client.GetAsync(uri).Result;

            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;
                Model.CharacterDataWrapper character = JsonConvert.DeserializeObject<Model.CharacterDataWrapper>(resultado);
                return character;
            }
            else
            {
                throw new Exception("Nenhum Resultado encontrado");
            }
        }

    }
}
