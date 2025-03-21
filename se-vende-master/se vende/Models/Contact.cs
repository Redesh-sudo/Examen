﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace se_vende.Models
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}