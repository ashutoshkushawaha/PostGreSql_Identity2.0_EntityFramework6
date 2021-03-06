﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PostGreSql.Models.Table
{
    [Table("sys_user")]

    public class sys_user
    {
        public int id { get; set; }
        public string user_name { get; set; }
        public string emp_no { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public int status_id { get; set; }
        public string login_name { get; set; }
        public string login_pwd { get; set; }
        public string login_salt { get; set; }
        public bool is_enabled { get; set; }
        public bool is_change_pwd { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public string report_lang { get; set; }
    }
}