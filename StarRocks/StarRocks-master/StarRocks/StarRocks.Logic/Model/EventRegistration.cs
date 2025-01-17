﻿using StarRocks.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Logic.Model
{
    public class EventRegistration : IEventRegistration
    {
        public int ID { get; set; }
        public int EventID { get; set; }
        public string AccountID { get; set; }
    }
}
