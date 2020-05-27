﻿using StarRocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Data.Entities
{
    public class Categorie : ICategorie
    {
        public int ID { get; set; }
        public int AccountID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}