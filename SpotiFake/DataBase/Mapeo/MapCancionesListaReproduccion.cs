﻿using SpotiFake.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SpotiFake.DataBase.Mapeo
{
    public class MapCancionesListaReproduccion : EntityTypeConfiguration<CancionesListaReproduccion>
    {
        public MapCancionesListaReproduccion()
        {
            ToTable("CancionesListaReproduccion");
        }
    }
}