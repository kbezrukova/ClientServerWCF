﻿using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Table(Name = "tbl_Users")]
    public class Users
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }
        [Column]
        public string Name { get; set; }
        [Column]
        public string Key1 { get; set; }
        [Column]
        public int Operations { get; set; }

    }
}
