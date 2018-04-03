using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PostGreSql.Models.Table
{
    [Table("company")]

    public class company
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        public int salary { get; set; }
        public char gender { get; set; }
        
    }
}