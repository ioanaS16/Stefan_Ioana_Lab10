using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stefan_Ioana_Lab10.Models
{
    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
