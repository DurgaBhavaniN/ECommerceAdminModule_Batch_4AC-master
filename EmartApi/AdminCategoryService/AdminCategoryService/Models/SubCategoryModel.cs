﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminCategoryService.Models
{
    public class SubCategoryModel
    {

        public int Subid { get; set; }
        public string Subname { get; set; }
        public int? Cid { get; set; }
        public string Sdetails { get; set; }
        public int? Gst { get; set; }
    }
}