using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Entidades
{
    public class ConexionProducto : IConexionApi<Producto>
    {
        HttpClient client;

        public ConexionProducto()
        {
            client = new HttpClient();
        }

        public bool Add(Producto entity, string url, string jwt)
        {
            try
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

                JsonObject json = new JsonObject()
                {
                    {"nombreProducto", entity.NombreProducto}
                };
                StringContent content = new StringContent(json.ToJsonString(), Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync(url, content).Result;

                if (response.StatusCode != System.Net.HttpStatusCode.Created)
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return true;
        }

        public string Mensaje(string mensaje)
        {
            return mensaje;
        }

        public List<Producto> GetAll(string url, string jwt)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);
            HttpResponseMessage response = client.GetAsync(url).Result;//obtengo la respuesta

            string resultado = response.Content.ReadAsStringAsync().Result; //leo el json y lo deserializo

            List<Producto> body = JsonConvert.DeserializeObject<List<Producto>>(resultado);

            return body;
        }

        public bool Remove(string url, string jwt)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

            HttpResponseMessage response = client.DeleteAsync(url).Result;
            if(response.StatusCode != System.Net.HttpStatusCode.NoContent)
            {
                return false;
            }
            return true;
        }

        public bool Update(Producto entity, string url, string jwt)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

            JsonObject jsonObject = new()
            {
                { "id", entity.Id },
                { "nombreProducto", entity.NombreProducto }
            };

            StringContent content = new StringContent(jsonObject.ToString(), Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PutAsync(url, content).Result;

            if (response.StatusCode != System.Net.HttpStatusCode.NoContent)
                return false;

            return true;
        }

    }
}
