﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageMuseum.Models
{
    public class ArtPiece
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double dimension { get; set; }

        //vai dar probelmas se for para inserir na base de dados porque este formato é maior que a BD suporta
        public DateTime Year { get; set; }
        public string Author { get; set; }
    }
}