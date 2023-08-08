using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Autenticacion
    {
        static HttpClient client;

        static Autenticacion()
        {
            client = new HttpClient();
        }

        public static AutorizacionResponse AutenticarUsuario(string correo, string clave, string url)
        {
            JsonObject json = new JsonObject()
                {
                    {"correo", correo},
                    {"clave", clave}
                };
            StringContent content = new StringContent(json.ToJsonString(), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(url, content).Result;

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return null;
            }
            string resultado = response.Content.ReadAsStringAsync().Result; 

            AutorizacionResponse modelo = JsonConvert.DeserializeObject<AutorizacionResponse>(resultado);
            return modelo;
        }


    }
}
