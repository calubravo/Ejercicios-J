using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PracticaJson
{
    internal class Ejercicio2
    {
        public string Usuario { get; set; }
        [JsonPropertyName("amigos_usuario")]
        public List<string> Amigos { get; set; }

        [JsonPropertyName("notificaciones_usuario")]
        public bool Notificaciones { get; set; }

        public Ejercicio2()
        {
            Amigos=new List<string>();  
        }
    }
}
