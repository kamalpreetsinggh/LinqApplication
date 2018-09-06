using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQApplication.Models.Student
{
    public class SearchProperties
    {
        public string searchBy { set; get; }
        public string search { get; set; }
        public string orderBy { get; set; }
        public int min { set; get; }
        public int max { set; get; }
    }
}
