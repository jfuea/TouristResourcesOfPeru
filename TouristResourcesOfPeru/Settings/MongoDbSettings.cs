﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristResourcesOfPeru.Settings
{
    public class MongoDbSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }

        public string User { get; set; }
        public string Password { get; set; }

        public string ConnectionString { 
            get
            {
                return $"mongodb+srv://{User}:{Password}@{Host}:{Port}";
            } 
        }
    }
}
