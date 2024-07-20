using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatGenetics
{
    public class BasePair
    {
        public Gene gene1 { get; set; }
        public Gene gene2 { get; set; }
        public List<Gene> genes;

        public BasePair(Gene gene1, Gene gene2)
        {
            this.gene1 = gene1;
            this.gene2 = gene2;
            
            ResolveDominance();
            this.genes = new List<Gene>() { this.gene1, this.gene2 };
        }

        public void ResolveDominance()
        {
            if(gene1.dominantOver.Contains(gene2))
            {
                //Do nothing, this is valid
            }
            else if(gene2.dominantOver.Contains(gene1))
            {
                //Flip them
                Gene temp = gene2;
                gene2 = gene1;
                gene1 = temp;
            }
        }

        public override string ToString()
        {
            return gene1.name + " / " + gene2.name;
        }
    }
}
