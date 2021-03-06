﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PathImage { get; set; }
        public int ReleaseYear { get; set; }
        public int DurationMin { get; set; }
        public int AgeCategory { get; set; }
        public double Rating { get; set; }
        public string TrailerLink { get; set; }
        public bool Hiden { get; set; }
    }
}
