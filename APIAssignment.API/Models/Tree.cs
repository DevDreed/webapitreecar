using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIAssignment.API.Models
{
    public class Tree
    {
        public int TreeId { get; set; }

        public string TreeName { get; set; }

        public int TreeHeight { get; set; }

        public int TreeAge { get; set; }
    }
}