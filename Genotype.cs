using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatGenetics
{
    public class Genotype
    {
        public List<BasePair> basePairs { get; set; }
        public string gender { get; set; }

        public Genotype(List<BasePair> basePairs, string gender)
        {
            this.basePairs = basePairs;
            this.gender = gender;
        }
    }
}
