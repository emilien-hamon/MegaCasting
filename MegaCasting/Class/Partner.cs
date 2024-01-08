using System;
using System.Collections.Generic;


namespace MegaCasting.Class
{
    public partial class Partner
    {
        public int ID { get; set; }
        public string Label { get; set; } = null!;

        public string SIRET { get; set; } = null!;
        public string Description { get; set; } = null!;

        public DateTime DateTime { get; set; }

    }
}