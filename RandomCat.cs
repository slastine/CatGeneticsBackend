using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatGenetics
{
    public static class RandomCat
    {
       
        public static Genotype GetRandomCat(bool female)
        {
            Random r = new Random();
            List<BasePair> basePairs = new List<BasePair>();

            //Black series
            int randomBlack = r.Next(0, 3);
            int randomBlack2 = r.Next(0, 3);
            Gene black1 = CatGeneticsProgram.black;
            Gene black2 = CatGeneticsProgram.black;
            switch (randomBlack)
            {
                case 0:
                    black1 = CatGeneticsProgram.black;
                    break;
                case 1:
                    black1 = CatGeneticsProgram.cinnamon;
                    break;
                case 2:
                    black1 = CatGeneticsProgram.chocolate;
                    break;
            }

            switch (randomBlack2)
            {
                case 0:
                    black2 = CatGeneticsProgram.black;
                    break;
                case 1:
                    black2 = CatGeneticsProgram.cinnamon;
                    break;
                case 2:
                    black2 = CatGeneticsProgram.chocolate;
                    break;
            }

            basePairs.Add(new BasePair(black1, black2));

            int ginger1 = r.Next(2);
            int ginger2 = r.Next(2);
            Gene ginger1Gene = CatGeneticsProgram.notGinger;
            Gene ginger2Gene = CatGeneticsProgram.notGinger;

            if(ginger1 == 0)
            {
                ginger1Gene = CatGeneticsProgram.ginger;
            }
            if(ginger2 == 0)
            {
                ginger2Gene = CatGeneticsProgram.ginger;
            }
            if(!female)
            {
                ginger2Gene = CatGeneticsProgram.male;
            }

            basePairs.Add(new BasePair(ginger1Gene, ginger2Gene));

            int agouti = r.Next(2);
            int agouti2 = r.Next(2);
            Gene agouti1Gene = agouti == 0 ? CatGeneticsProgram.agouti : CatGeneticsProgram.self;
            Gene agouti2Gene = agouti2 == 0 ? CatGeneticsProgram.agouti : CatGeneticsProgram.self;

            basePairs.Add(new BasePair(agouti1Gene, agouti2Gene));

            int mackeral = r.Next(2);
            int classic = r.Next(2);
            Gene mackeralGene = mackeral == 0 ? CatGeneticsProgram.mackeral : CatGeneticsProgram.classic;
            Gene classicGene = classic == 0 ? CatGeneticsProgram.mackeral : CatGeneticsProgram.classic;

            basePairs.Add(new BasePair(mackeralGene, classicGene));


            int spotted = r.Next(2);
            int spotted2 = r.Next(2);
            Gene spotted1Gene = spotted == 0 ? CatGeneticsProgram.spotted : CatGeneticsProgram.notSpotted;
            Gene spotted2Gene = spotted2 == 0 ? CatGeneticsProgram.spotted : CatGeneticsProgram.notSpotted;

            basePairs.Add(new BasePair(spotted1Gene, spotted2Gene));

            int ticked = r.Next(2);
            int ticked2 = r.Next(2);
            Gene ticked1Gene = ticked == 0 ? CatGeneticsProgram.ticked : CatGeneticsProgram.notTicked;
            Gene ticked2Gene = ticked2 == 0 ? CatGeneticsProgram.ticked : CatGeneticsProgram.notTicked;

            basePairs.Add(new BasePair(ticked1Gene, ticked2Gene));

            int diluted = r.Next(3);
            int diluted2 = r.Next(3);
            Gene diluted1Gene = diluted == 0 ? CatGeneticsProgram.diluted : CatGeneticsProgram.notDiluted;
            Gene diluted2Gene = diluted2 == 0 ? CatGeneticsProgram.diluted : CatGeneticsProgram.notDiluted;

            basePairs.Add(new BasePair(diluted1Gene, diluted2Gene));

            int inhibited = r.Next(2);
            int inhibited2 = r.Next(2);
            Gene inhibited1Gene = inhibited == 0 ? CatGeneticsProgram.inhibited : CatGeneticsProgram.notInhibited;
            Gene inhibited2Gene = inhibited2 == 0 ? CatGeneticsProgram.inhibited : CatGeneticsProgram.notInhibited;

            basePairs.Add(new BasePair(inhibited1Gene, inhibited2Gene));

            int widebanding = r.Next(2);
            int widebanding2 = r.Next(2);
            Gene widebanding1Gene = widebanding == 0 ? CatGeneticsProgram.widebanding : CatGeneticsProgram.notWidebanding;
            Gene widebanding2Gene = widebanding2 == 0 ? CatGeneticsProgram.widebanding : CatGeneticsProgram.notWidebanding;

            basePairs.Add(new BasePair(widebanding1Gene, widebanding2Gene));


            int randomELocus = r.Next(0, 4);
            int randomELocus2 = r.Next(0, 4);
            Gene eLocus1 = CatGeneticsProgram.black;
            Gene eLocus2 = CatGeneticsProgram.black;
            switch (randomELocus)
            {
                case 0:
                    eLocus1 = CatGeneticsProgram.normal;
                    break;
                case 1:
                    eLocus1 = CatGeneticsProgram.amber;
                    break;
                case 2:
                    eLocus1 = CatGeneticsProgram.russet;
                    break;
                case 3:
                    eLocus1 = CatGeneticsProgram.carnelian;
                    break;
            }

            switch (randomELocus2)
            {
                case 0:
                    eLocus2 = CatGeneticsProgram.normal;
                    break;
                case 1:
                    eLocus2 = CatGeneticsProgram.amber;
                    break;
                case 2:
                    eLocus2 = CatGeneticsProgram.russet;
                    break;
                case 3:
                    eLocus2 = CatGeneticsProgram.carnelian;
                    break;
            }

            basePairs.Add(new BasePair(eLocus1, eLocus2));


            int randomCLocus = r.Next(0, 4);
            int randomCLocus2 = r.Next(0, 4);
            Gene cLocus1 = CatGeneticsProgram.black;
            Gene cLocus2 = CatGeneticsProgram.black;
            switch (randomCLocus)
            {
                case 0:
                    cLocus1 = CatGeneticsProgram.nonSiamese;
                    break;
                case 1:
                    cLocus1 = CatGeneticsProgram.siamese;
                    break;
                case 2:
                    cLocus1 = CatGeneticsProgram.sepia;
                    break;
                case 3:
                    cLocus1 = CatGeneticsProgram.albino;
                    break;
            }

            switch (randomCLocus2)
            {
                case 0:
                    cLocus2 = CatGeneticsProgram.nonSiamese;
                    break;
                case 1:
                    cLocus2 = CatGeneticsProgram.siamese;
                    break;
                case 2:
                    cLocus2 = CatGeneticsProgram.sepia;
                    break;
                case 3:
                    cLocus2 = CatGeneticsProgram.albino;
                    break;
            }

            basePairs.Add(new BasePair(cLocus1, cLocus2));

            int randomSLocus = r.Next(0, 5);
            int randomSLocus2 = r.Next(0, 5);
            Gene sLocus1 = CatGeneticsProgram.black;
            Gene sLocus2 = CatGeneticsProgram.black;
            switch (randomSLocus)
            {
                case 0:
                    sLocus1 = CatGeneticsProgram.whiteDominant;
                    break;
                case 1:
                    sLocus1 = CatGeneticsProgram.noWhite;
                    break;
                case 2:
                    sLocus1 = CatGeneticsProgram.whiteSpotting;
                    break;
                case 3:
                    sLocus1 = CatGeneticsProgram.noWhite;
                    break;
                case 4:
                    sLocus1 = CatGeneticsProgram.whiteSpotting;
                    break;
            }

            switch (randomSLocus2)
            {
                case 0:
                    sLocus2 = CatGeneticsProgram.whiteDominant;
                    break;
                case 1:
                    sLocus2 = CatGeneticsProgram.noWhite;
                    break;
                case 2:
                    sLocus2 = CatGeneticsProgram.whiteSpotting;
                    break;
                case 3:
                    sLocus1 = CatGeneticsProgram.noWhite;
                    break;
                case 4:
                    sLocus1 = CatGeneticsProgram.whiteSpotting;
                    break;
            }

            basePairs.Add(new BasePair(sLocus1, sLocus2));

            int hairlength = r.Next(2);
            int hairlength2 = r.Next(2);
            Gene hairlength1Gene = hairlength == 0 ? CatGeneticsProgram.shorthair : CatGeneticsProgram.longhair;
            Gene hairlength2Gene = hairlength2 == 0 ? CatGeneticsProgram.shorthair : CatGeneticsProgram.longhair;

            basePairs.Add(new BasePair(hairlength1Gene, hairlength2Gene));

            return new Genotype(basePairs, female ? "she-cat" : "tom");
        }
    }
}
