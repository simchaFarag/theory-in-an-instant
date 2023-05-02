using System;
using System.Collections.Generic;

#nullable disable

namespace MODELS.MODELS
{
    public partial class questionArr
    {
        public int id { get; set; }
        public string question { get; set; }
        public string e1 { get; set; }
        public string e2 { get; set; }
        public string e3 { get; set; }
        public string e4 { get; set; }
        public int? r { get; set; }
        public string img { get; set; }
    }
}
