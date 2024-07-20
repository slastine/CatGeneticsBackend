using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatGenetics
{
    public class PunnetSquare
    {
        public BasePair[][] square;
        public Genotype father;
        public Genotype mother;
        int locus;

        public PunnetSquare(Genotype father, Genotype mother, int locus)
        {
            this.father = father;
            this.mother = mother;
            this.locus = locus;
            square = new BasePair[2][];
            square[0] = new BasePair[2];
            square[1] = new BasePair[2];
            square[0][0] = new BasePair(father.basePairs[locus].gene1, mother.basePairs[locus].gene1);
            square[1][0] = new BasePair(father.basePairs[locus].gene2, mother.basePairs[locus].gene1);
            square[0][1] = new BasePair(father.basePairs[locus].gene1, mother.basePairs[locus].gene2);
            square[1][1] = new BasePair(father.basePairs[locus].gene2, mother.basePairs[locus].gene2);
        }

        public override string ToString()
        {
            string header = "     " + string.Join("  ", father.basePairs[locus].gene1.name + "   " + father.basePairs[locus].gene2.name) + "\n";
            string[] rows = new string[2];
            for (int i = 0; i < 2; i++)
            {
                rows[i] = $"{mother.basePairs[locus].genes[i].name}  " + string.Join("  ", GetRow(i));
            }
            return header + string.Join("\n", rows);
        }

        private string[] GetRow(int rowIndex)
        {
            string[] row = new string[2];
            for (int j = 0; j < 2; j++)
            {
                row[j] = String.Join(" ", square[j][rowIndex].genes.Select(x => x.name));
            }
            return row;
        }
    }
}
