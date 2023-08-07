using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate string MensajeError(string msg);
    public class ConexionProducto : IConexionApi<Producto>
    {
        HttpClient client;

        public ConexionProducto()
        {
            client = new HttpClient();
        }

        public bool Add(Producto entity, string url)
        {
            try
            {
                client.DefaultRequestHeaders.Clear();
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
                MensajeError delegado = Mensaje;
                delegado.Invoke("Hubo un error");
            }
            

            return true;
        }

        public string Mensaje(string mensaje)
        {
            return mensaje;
        }

        public List<Producto> GetAll(string url)
        {
            client.DefaultRequestHeaders.Clear();
            HttpResponseMessage response = client.GetAsync(url).Result;//obtengo la respuesta

            string resultado = response.Content.ReadAsStringAsync().Result; //leo el json y lo deserializo

            List<Producto> body = JsonConvert.DeserializeObject<List<Producto>>(resultado);

            return body;
        }

        public bool Remove(string url)
        {
            client.DefaultRequestHeaders.Clear();

            HttpResponseMessage response = client.DeleteAsync(url).Result;
            if(response.StatusCode != System.Net.HttpStatusCode.NoContent)
            {
                return false;
            }
            return true;
        }

        public bool Update(Producto entity, string url)
        {
            throw new NotImplementedException();
        }
    }
}
