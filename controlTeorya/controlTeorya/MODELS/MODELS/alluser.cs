using System;
using System.Collections.Generic;

#nullable disable

namespace MODELS.MODELS
{
    public partial class alluser
    {
        public int? ID { get; set; }
        public string password { get; set; }
        public string addres { get; set; }
        public string phon { get; set; }
        public string mail { get; set; }
        public int? status { get; set; }
    }
}
