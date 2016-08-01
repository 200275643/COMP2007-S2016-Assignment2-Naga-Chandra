namespace COMP2007_S2016_Assignment2_Naga_Chandra.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MenuItem
    {
        public int ID { get; set; }

        public string ItemName { get; set; }

        public decimal ItemPrice { get; set; }

        public string ShortDesc { get; set; }

        public string LongDesc { get; set; }

        public string ThumbnailURL { get; set; }

        public string FullsizeURL { get; set; }
    }
}
