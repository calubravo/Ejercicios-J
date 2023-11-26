using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaJson
{
    internal class ListadoEquipos
    {
        public List<Estadistica> estadistica { get; set; }
        public ListadoEquipos()
        {
            List<Estadistica> Estadistica = new List<Estadistica>();
            List<Jugador> jugadoresLista = new List<Jugador>();

        }
        internal class Estadistica
        {
            public string Equipo { get; set; }
            public List<Jugador> Jugadores { get; set; }
            public bool Campeon { get; set; }

        }
    }
}
