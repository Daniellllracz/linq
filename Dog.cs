using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Dog
    {
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public bool Sex { get; set;}
        public string Breed { get; set; }
        public int Age => DateTime.Now.Year - Birth.Year;
        public float Weight { get; set; }




    }
}
