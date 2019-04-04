﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpotiFake.Models
{
    public class Cancion
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Artista artista { get; set; }
        public Album album { get; set; }

        public List<CancionesEscuchadas> cancionesEscuchadas { get; set; }
        public List<CancionesListaReproduccion> cancionesListaReproduccions { get; set; }
    }
}