using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatGenetics
{
    public static class CatGenerator
    {
        public static string PhenotypeFromGenotype(Genotype g, string name)
        {
            //Base string
            string s = "";

            //Base color
            s += $"{name} is ";
            string baseColor = GetBaseColor(g);
            bool startsWithVowel = baseColor.StartsWith("a");
            if (startsWithVowel)
            {
                s += "an ";
            }
            else
            {
                s += "a ";
            }
            s += baseColor;
            s += " " + g.gender + GetTabby(g);
            string siameseString = GetSiamese(g);
            if (siameseString.Contains(" is white from head to tail with a red nose."))
            {
                siameseString = siameseString.Replace("and", "with");
                s = $"{name} is a {g.gender} who" + siameseString;
            }
            else if (!baseColor.Contains("calico") && !baseColor.Contains("tortiseshell"))
            {
                if (!s.Contains("with"))
                {
                    siameseString = siameseString.Replace("and", "with");
                }
                s += siameseString + ".";
            }
            string whiteString = GetWhiteSpots(g);
            if (whiteString == "White" && !siameseString.Contains(" is white from head to tail with a red nose."))
            {
                s = $"{name} is a white " + g.gender + ".";
            }
            else if (!baseColor.Contains("calico") && !baseColor.Contains("tortiseshell") && !siameseString.Contains(" is white from head to tail with a red nose."))
            {
                s += whiteString;
            }
            s += $" Their fur is {GetHairLength(g)}.";
            return s;
        }

        public static string GetHairLength(Genotype g)
        {
            string hairGene = g.basePairs[12].gene1.name;
            if (hairGene == "L") return "short";
            else return "long";
        }

        public static string GetWhiteSpots(Genotype g)
        {
            string whiteGene = g.basePairs[11].gene1.name;
            string whiteGene2 = g.basePairs[11].gene2.name;

            if(whiteGene == "Wd")
            {
                return "White";
            }
            else if(whiteGene == "S" || whiteGene2 == "w")
            {
                return " They have white spots on some of their body.";
            }
            else if (whiteGene == "S" || whiteGene2 == "S")
            {
                return " They have white spots on most of their body";
            }
            else if(whiteGene == "w")
            {
                return "";
            }
            return "";
        }

        public static string GetSiamese(Genotype g)
        {
            string siameseGene = g.basePairs[10].gene1.name;
            string siameseGene2 = g.basePairs[10].gene2.name;

            if(siameseGene == "C")
            {
                return "";
            }

            if(siameseGene == "cs" && siameseGene2 != "cb")
            {
                return " and siamese coloration";
            }
            else if(siameseGene == "cb" && siameseGene2 != "cs")
            {
                return " and sepia coloration";
            }
            else if (siameseGene == "cs" && siameseGene2 == "cb")
            {
                return " and mink coloration";
            }
            else if(siameseGene == "c" && siameseGene2 == "c")
            {
                return " is white from head to tail with a red nose.";
            }
            return "";
        }

        public static string GetTabby(Genotype g)
        {
            string agoutiGene = g.basePairs[2].gene1.name;
            if (agoutiGene != "A") return "";

            string gingerGene = g.basePairs[1].gene1.name;
            string gingerGene2 = g.basePairs[1].gene2.name;
            bool isGinger = false;
            bool isTortie = false;


            if (gingerGene == "O" && gingerGene2 == "O")
            {
                isGinger = true;
            }
            else if (gingerGene == "O" && gingerGene2 == "o")
            {
                isTortie = true;
            }

            if (isGinger)
            {
                return " with tabby markings";
            }
            if (isTortie)
            {
                return "";
            }

            string tickedGene = g.basePairs[4].gene1.name;
            string tickedGene2 = g.basePairs[4].gene2.name;
            if (tickedGene == "Ta" && tickedGene2 == "ta")
            {
                return " with tabby markings on their legs and face";
            }
            else if(tickedGene == "Ta")
            {
                return " with ticked markings";
            }

            string spottedGene = g.basePairs[3].gene1.name;
            if (spottedGene == "Sp")
            {
                return " with spots";
            }

            string mackeralGene = g.basePairs[2].gene1.name;
            if(mackeralGene == "Mc")
            {
                return " with mackeral tabby markings";
            }
            else
            {
                return " with classic tabby markings";
            }
        }

        public static string GetBaseColor(Genotype g)
        {
            string blackBaseGene = g.basePairs[0].gene1.name;
            string baseColor = "";
            if (blackBaseGene == "B")
            {
                baseColor = "black";
            }
            else if (blackBaseGene == "b")
            {
                baseColor = "chocolate";
            }
            else
            {
                baseColor = "cinnamon";
            }

            string gingerGene = g.basePairs[1].gene1.name;
            string gingerGene2 = g.basePairs[1].gene2.name;
            bool isGinger = false;
            bool isTortie = false;


            if(gingerGene == "O" && gingerGene2 == "O")
            {
                isGinger = true;
            }
            else if(gingerGene == "O" && gingerGene2 == "o")
            {
                isTortie = true;
            }

            if(isGinger)
            {
                baseColor = "ginger";
            }
            if(isTortie)
            {
                string siameseGene = g.basePairs[10].gene1.name;
                string siameseGene2 = g.basePairs[10].gene2.name;
                if(siameseGene != "Wd" && siameseGene != "w" )
                {
                    baseColor = "calico";
                }
                else
                {
                    baseColor = "tortiseshell";
                }
            }


            string widebandingGene = g.basePairs[7].gene1.name;
            if (widebandingGene == "Wd")
            {
                baseColor = "golden";
            }

            string eLocus = g.basePairs[8].gene1.name;
            switch(eLocus)
            {
                case "E":
                    break;
                case "e":
                    if(!isGinger && !isTortie)
                    {
                        baseColor = "amber";
                    }
                    break;
                case "r":
                     if (!isGinger && !isTortie)
                    {
                        baseColor = "russet";
                    }
                    break;
                case "ec":
                    if (!isGinger && !isTortie)
                    {
                        baseColor = "carnelian";
                    }
                    break;
            }

            string inhibitorGene = g.basePairs[7].gene1.name;
            string agoutiGene = g.basePairs[2].gene1.name;
            if(inhibitorGene == "I" && agoutiGene == "A")
            {
                baseColor = "silver";
            }
            else if(inhibitorGene == "I")
            {
                baseColor += " smoke";
            }

            string dilutionGene = g.basePairs[6].gene1.name; 
            if(dilutionGene == "D")
            {
                baseColor = "diluted " + baseColor;
            }
            return baseColor;
        }
    }
}
