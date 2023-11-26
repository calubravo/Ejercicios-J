using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PracticaJson
{
    internal class Ejercicio4
    {
        public List<Producto> Productos { get; set; }
        public Ejercicio4()
        {
            List<Producto> prod = new List<Producto>();
            List<string> etq = new List<string>();

        }

  
        public class Producto
        {
            public string Nombre { get; set; }
            public float Precio { get; set; }
            public int Existencias { get; set; }

            [JsonPropertyName("descuento_disponible")]
            public bool Descuento { get; set; }
            public List<string> Etiquetas  { get; set; }
            public Detalle Detalles { get; set; }
           
       
            public class Detalle
            {
                public float Peso { get; set; }
                public Dimension Dimensiones { get; set; }


                public class Dimension
                    {
                        public float Alto { get; set; }
                        public float Ancho { get; set; }
                        public float Profundidad { get; set; }
                    }
             }
        }
    }
}
