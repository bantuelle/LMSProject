﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentModule
    {
        public int StudentModuleID { get; set; }
        public int LecturerModuleID { get; set; }
        public int UserID { get; set; }
        public string Date { get; set; }
        public string StudModStatus { get; set; }
    }
}
