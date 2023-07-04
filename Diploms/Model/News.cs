namespace Diplom.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class News
    {
        public string header_news { get; set; }
        public string description_news { get; set; }
        public DateTime? date_start { get; set; }
        public DateTime? date_end { get; set; }
        public byte[] photo { get; set; }
        public int id_news { get; set; }
    }
}
