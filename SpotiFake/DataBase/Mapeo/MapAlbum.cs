﻿using SpotiFake.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SpotiFake.DataBase.Mapeo
{
    public class MapAlbum : EntityTypeConfiguration<Album>
    {
        public MapAlbum()
        {
            ToTable("Album");
        }
    }
}