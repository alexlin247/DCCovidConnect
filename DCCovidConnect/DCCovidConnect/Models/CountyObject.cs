﻿using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace DCCovidConnect.Models
{
    class CountyObject
    {
        public string State { get; set; }
        public string StateAbbrev { get; set; }
        public string County { get; set; }
        public int FIPS { get; set; }
        public SKPath Path { get; set; }
    }
}
