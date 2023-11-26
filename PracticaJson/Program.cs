
using System.Text.Json;

namespace PracticaJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Carga del directorio de los JSON
            string pathEjercicioUno = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio1.json");
            string pathEjercicioDos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio2.json");
            string pathEjercicioTres = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio3.json");
            string pathEjercicioCuatro = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio4.json");
            #endregion

            string ejercicio1 = File.ReadAllText(pathEjercicioUno);

            string ejercicio2 = File.ReadAllText(pathEjercicioDos);

            string ejercicio3 = File.ReadAllText(pathEjercicioTres);

            string ejercicio4 = File.ReadAllText(pathEjercicioCuatro);


            var option = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };

            // ---------------------Ejercicio 1---------------------------------
            Ejercicio1 JSON1 = JsonSerializer.Deserialize<Ejercicio1>(ejercicio1)!;


            // ---------------------Ejercicio 2---------------------------------

            Ejercicio2 JSON2 = JsonSerializer.Deserialize<Ejercicio2>(ejercicio2)!;

            // ---------------------Ejercicio 3---------------------------------
            ListadoEquipos JSON3 = JsonSerializer.Deserialize<ListadoEquipos>(ejercicio3)!;


            // ---------------------Ejercicio 4---------------------------------
            Ejercicio4 JSON4 = JsonSerializer.Deserialize<Ejercicio4>(ejercicio4)!;

            Console.ReadKey();
            
        }
    }
}