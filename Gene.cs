using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatGenetics
{
    public class Gene
    {
        public string name { get; set; }
        public List<Gene> dominantOver;

        public Gene(string name, List<Gene> dominantOver)
        {
            this.name = name;
            this.dominantOver = dominantOver;
        }
    }
}
