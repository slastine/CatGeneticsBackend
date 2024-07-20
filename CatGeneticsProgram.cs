using CatGenetics;

public static class CatGeneticsProgram
{
    //Used in many
    public static Gene male = new Gene("y", new List<Gene>());

    //Black series
    public static Gene black = new Gene("B", new List<Gene>());
    public static Gene chocolate = new Gene("b", new List<Gene>());
    public static Gene cinnamon = new Gene("b1", new List<Gene>());

    //Ginger series
    public static Gene ginger = new Gene("O", new List<Gene>());
    public static Gene notGinger = new Gene("o", new List<Gene>());

    //Agouti
    public static Gene agouti = new Gene("A", new List<Gene>());
    public static Gene self = new Gene("a", new List<Gene>());

    //Mackeral
    public static Gene mackeral = new Gene("Mc", new List<Gene>());
    public static Gene classic = new Gene("mc", new List<Gene>());
     
    //Spotted - ask about this
    public static Gene spotted = new Gene("Sp", new List<Gene>());
    public static Gene notSpotted = new Gene("sp", new List<Gene>());

    //Ticked
    public static Gene ticked = new Gene("Ta", new List<Gene>());
    public static Gene notTicked = new Gene("ta", new List<Gene>());

    //Rufosing - How to represent this?

    //Dilution
    public static Gene diluted = new Gene("D", new List<Gene>());
    public static Gene notDiluted = new Gene("d", new List<Gene>());

    //Inhibitor
    public static Gene inhibited = new Gene("I", new List<Gene>());
    public static Gene notInhibited = new Gene("i", new List<Gene>());

    //Widebanding
    public static Gene widebanding = new Gene("Wd", new List<Gene>());
    public static Gene notWidebanding = new Gene("wd", new List<Gene>());

    //Extension
    public static Gene normal = new Gene("E", new List<Gene>());
    public static Gene amber = new Gene("e", new List<Gene>());
    public static Gene russet = new Gene("r", new List<Gene>());
    public static Gene carnelian = new Gene("ec", new List<Gene>());

    //Siamese
    public static Gene nonSiamese = new Gene("C", new List<Gene>());
    public static Gene siamese = new Gene("cs", new List<Gene>());
    public static Gene sepia = new Gene("cb", new List<Gene>());
    public static Gene albino = new Gene("c", new List<Gene>());

    //White
    public static Gene whiteDominant = new Gene("Wd", new List<Gene>());
    public static Gene noWhite = new Gene("w", new List<Gene>());
    public static Gene whiteSpotting = new Gene("S", new List<Gene>());

    //Hair length
    public static Gene longhair = new Gene("l", new List<Gene>());
    public static Gene shorthair = new Gene("L", new List<Gene>());

    static Genotype father;
    static Genotype mother;

    static int lociCount = 13;
    static int litterSize = 5;

    public static bool initialized = false;

    public static Genotype ParentFromStrings(bool female, string f, string f2)
    {
        if (f == null || f2 == null) return null;
        List<BasePair> basePairs = new List<BasePair>();

        Gene blackSeriesGene = CatGeneticsProgram.black;
        Gene blackSeriesGene2 = CatGeneticsProgram.black;
        if (f.Contains("black"))
        {
            blackSeriesGene = CatGeneticsProgram.black;
        }
        else if (f.Contains("chocolate"))
        {
            blackSeriesGene = CatGeneticsProgram.chocolate;
        }
        else
        {
            blackSeriesGene = CatGeneticsProgram.cinnamon;
        }
        if (f2.Contains("black"))
        {
            blackSeriesGene2 = CatGeneticsProgram.black;
        }
        else if (f2.Contains("chocolate"))
        {
            blackSeriesGene2 = CatGeneticsProgram.chocolate;
        }
        else
        {
            blackSeriesGene2 = CatGeneticsProgram.cinnamon;
        }
        BasePair blackSeries = new BasePair(blackSeriesGene, blackSeriesGene2);
        basePairs.Add(blackSeries);

        Gene gingerGene = CatGeneticsProgram.ginger;
        Gene gingerGene2 = CatGeneticsProgram.ginger;

        if (f.Contains("notGinger"))
        {
            gingerGene = CatGeneticsProgram.notGinger;
        }
        if (f2.Contains("notGinger"))
        {
            gingerGene2 = CatGeneticsProgram.notGinger;
        }
        if(!female)
        {
            gingerGene2 = male;
        }
        BasePair ginger = new BasePair(gingerGene, gingerGene2);
        basePairs.Add(ginger);

        Gene agoutiGene = CatGeneticsProgram.agouti;
        Gene agoutiGene2 = CatGeneticsProgram.agouti;

        if (f.Contains("self"))
        {
            agoutiGene = CatGeneticsProgram.self;
        }
        if (f2.Contains("self"))
        {
            agoutiGene2 = CatGeneticsProgram.self;
        }
        BasePair agouti = new BasePair(agoutiGene, agoutiGene2);
        basePairs.Add(agouti);

        Gene tabbyGene = CatGeneticsProgram.mackeral;
        Gene tabbyGene2 = CatGeneticsProgram.mackeral;

        if (f.Contains("classic"))
        {
            tabbyGene = CatGeneticsProgram.classic;
        }
        if (f2.Contains("classic"))
        {
            tabbyGene2 = CatGeneticsProgram.classic;
        }
        BasePair tabby = new BasePair(tabbyGene, tabbyGene2);
        basePairs.Add(tabby);

        Gene spottedGene = CatGeneticsProgram.spotted;
        Gene spottedGene2 = CatGeneticsProgram.spotted;

        if (f.Contains("notSpotted"))
        {
            spottedGene = CatGeneticsProgram.notSpotted;
        }
        if (f2.Contains("notSpotted"))
        {
            spottedGene2 = CatGeneticsProgram.notSpotted;
        }
        BasePair spotted = new BasePair(spottedGene, spottedGene2);
        basePairs.Add(spotted);

        Gene tickedGene = CatGeneticsProgram.ticked;
        Gene tickedGene2 = CatGeneticsProgram.ticked;

        if (f.Contains("notTicked"))
        {
            tickedGene = CatGeneticsProgram.notTicked;
        }
        if (f2.Contains("notTicked"))
        {
            tickedGene2 = CatGeneticsProgram.notTicked;
        }
        BasePair ticked = new BasePair(tickedGene, tickedGene2);
        basePairs.Add(ticked);


        Gene dilutedGene = CatGeneticsProgram.diluted;
        Gene dilutedGene2 = CatGeneticsProgram.diluted;

        if (f.Contains("notDiluted"))
        {
            dilutedGene = CatGeneticsProgram.notDiluted;
        }
        if (f2.Contains("notDiluted"))
        {
            dilutedGene2 = CatGeneticsProgram.notDiluted;
        }
        BasePair diluted = new BasePair(dilutedGene, dilutedGene2);
        basePairs.Add(diluted);

        Gene inhibitedGene = CatGeneticsProgram.inhibited;
        Gene inhibitedGene2 = CatGeneticsProgram.inhibited;

        if (f.Contains("notInhibited"))
        {
            inhibitedGene = CatGeneticsProgram.notInhibited;
        }
        if (f2.Contains("notInhibited"))
        {
            inhibitedGene2 = CatGeneticsProgram.notInhibited;
        }
        BasePair inhibited = new BasePair(inhibitedGene, inhibitedGene2);
        basePairs.Add(inhibited);

        Gene widebandingGene = CatGeneticsProgram.widebanding;
        Gene widebandingGene2 = CatGeneticsProgram.widebanding;

        if (f.Contains("notWidebanding"))
        {
            widebandingGene = CatGeneticsProgram.notWidebanding;
        }
        if (f2.Contains("notWidebanding"))
        {
            widebandingGene2 = CatGeneticsProgram.notWidebanding;
        }
        BasePair widebanding = new BasePair(widebandingGene, widebandingGene2);
        basePairs.Add(widebanding);

        Gene extensionGene = CatGeneticsProgram.normal;
        Gene extensionGene2 = CatGeneticsProgram.normal;

        if (f.Contains("amber"))
        {
            extensionGene = CatGeneticsProgram.amber;
        }
        else if (f.Contains("russet"))
        {
            extensionGene = CatGeneticsProgram.russet;
        }
        else if (f.Contains("carnelian"))
        {
            extensionGene = CatGeneticsProgram.carnelian;
        }
        if (f2.Contains("amber"))
        {
            extensionGene2 = CatGeneticsProgram.amber;
        }
        else if (f2.Contains("russet"))
        {
            extensionGene2 = CatGeneticsProgram.russet;
        }
        else if (f2.Contains("carnelian"))
        {
            extensionGene2 = CatGeneticsProgram.carnelian;
        }

        BasePair extensionPair = new BasePair(extensionGene, extensionGene2);
        basePairs.Add(extensionPair);

        Gene siameseGene = CatGeneticsProgram.nonSiamese;
        Gene siameseGene2 = CatGeneticsProgram.nonSiamese;

        if (f.Contains("siamese") && !f.Contains("nonSiamese"))
        {
            siameseGene = CatGeneticsProgram.siamese;
        }
        else if (f.Contains("sepia"))
        {
            siameseGene = CatGeneticsProgram.sepia;
        }
        else if (f.Contains("albino"))
        {
            siameseGene = CatGeneticsProgram.albino;
        }
        if (f2.Contains("siamese") && !f.Contains("nonSiamese"))
        {
            siameseGene2 = CatGeneticsProgram.siamese;
        }
        else if (f2.Contains("sepia"))
        {
            siameseGene2 = CatGeneticsProgram.sepia;
        }
        else if (f2.Contains("albino"))
        {
            siameseGene2 = CatGeneticsProgram.albino;
        }

        BasePair siamese = new BasePair(siameseGene, siameseGene2);
        basePairs.Add(siamese);

        Gene whiteGene = CatGeneticsProgram.noWhite;
        Gene whiteGene2 = CatGeneticsProgram.noWhite;

        if (f.Contains("whiteDominant"))
        {
            whiteGene = CatGeneticsProgram.whiteDominant;
        }
        else if (f.Contains("whiteSpotting"))
        {
            whiteGene = CatGeneticsProgram.whiteSpotting;
        }
        if (f2.Contains("whiteDominant"))
        {
            whiteGene2 = CatGeneticsProgram.whiteDominant;
        }
        else if (f2.Contains("whiteSpotting"))
        {
            whiteGene2 = CatGeneticsProgram.whiteSpotting;
        }

        BasePair white = new BasePair(whiteGene, whiteGene2);
        basePairs.Add(white);

        Gene longhairGene = CatGeneticsProgram.longhair;
        Gene longhairGene2 = CatGeneticsProgram.longhair;

        if (f.Contains("shorthair"))
        {
            longhairGene = CatGeneticsProgram.shorthair;
        }
        if (f2.Contains("shorthair"))
        {
            longhairGene2 = CatGeneticsProgram.shorthair;
        }
        BasePair shorthair = new BasePair(longhairGene, longhairGene2);
        basePairs.Add(shorthair);

        return new Genotype(basePairs, female ? "she-cat" : "tom");
    }

    public static Genotype KittenFromStrings(string f, string f2, string m, string m2)
    {
        Genotype mother = ParentFromStrings(true, m, m2);
        Genotype father = ParentFromStrings(false, f, f2);
        return (CatGeneticsProgram.SquareToGenotype(CatGeneticsProgram.Breed(father, mother)));
    }
    public static void Init()
    {
        if (initialized) return;
        initialized = true;
        black.dominantOver.Add(chocolate);
        black.dominantOver.Add(cinnamon);
        chocolate.dominantOver.Add(cinnamon);
        ginger.dominantOver.Add(male);
        ginger.dominantOver.Add(notGinger);
        notGinger.dominantOver.Add(male);
        agouti.dominantOver.Add(self);
        mackeral.dominantOver.Add(classic);
        diluted.dominantOver.Add(notDiluted);
        inhibited.dominantOver.Add(notInhibited);
        widebanding.dominantOver.Add(notWidebanding);
        normal.dominantOver.Add(carnelian);
        normal.dominantOver.Add(amber);
        normal.dominantOver.Add(russet);
        carnelian.dominantOver.Add(amber);
        carnelian.dominantOver.Add(russet);
        amber.dominantOver.Add(russet);
        nonSiamese.dominantOver.Add(siamese);
        nonSiamese.dominantOver.Add(sepia);
        nonSiamese.dominantOver.Add(albino);
        siamese.dominantOver.Add(albino);
        siamese.dominantOver.Add(sepia);
        sepia.dominantOver.Add(albino);
        whiteDominant.dominantOver.Add(noWhite);
        whiteDominant.dominantOver.Add(whiteSpotting);
        whiteSpotting.dominantOver.Add(noWhite);
        shorthair.dominantOver.Add(longhair);

        /*father = new Genotype(new List<BasePair>() 
        { 
            new BasePair(black, chocolate), 
            new BasePair(notGinger, male),
            new BasePair(agouti, self),
            new BasePair(mackeral, mackeral),
            new BasePair(ticked, notTicked),
            new BasePair(diluted, notDiluted),
            new BasePair(inhibited, inhibited),
            new BasePair(notWidebanding, notWidebanding),
            new BasePair(amber, amber),
        }, 
        "tom");
        mother = new Genotype(new List<BasePair>() 
        { 
            new BasePair(black, black), 
            new BasePair(ginger, ginger),
            new BasePair(agouti, agouti),
            new BasePair(classic, classic),
            new BasePair(ticked, notTicked),
            new BasePair(diluted, notDiluted),
            new BasePair(inhibited, notInhibited),
            new BasePair(notWidebanding, notWidebanding),
            new BasePair(normal, normal),
        },
        "she-cat");*/

        father = RandomCat.GetRandomCat(false);
        mother = RandomCat.GetRandomCat(true);
    }
    private static void Main(string[] args)
    {
        Init();
        for(int i =0; i < litterSize; i++)
        {
            Genotype g = SquareToGenotype(Breed(father, mother));
            Console.WriteLine(CatGenerator.PhenotypeFromGenotype(g, $"Kitten{i}"));
        }
    }

    public static List<PunnetSquare> Breed(Genotype father, Genotype mother)
    {
        List<PunnetSquare> squares = new List<PunnetSquare>();
        for(int i = 0; i < lociCount; i++)
        {
            PunnetSquare square = new PunnetSquare(father, mother, i);
            //Console.WriteLine(square.ToString());
            squares.Add(square);
        }
        return squares;
    }
    public static Genotype SquareToGenotype(List<PunnetSquare> p)
    {
        Random r = new Random();
        string g = r.NextDouble() > .5 ? "she-cat" : "tom";
        List<BasePair> basePairs = new List<BasePair>();
        for(int i = 0; i < p.Count; i++)
        {
            int x = r.Next(0, 2);
            int y = r.Next(0, 2);
            basePairs.Add(p[i].square[x][y]);
            //Console.WriteLine(basePairs.Last().ToString());
        }
        string gingerGene = basePairs[1].gene1.name;
        string gingerGene2 = basePairs[1].gene2.name;
        if ((gingerGene == "O" && gingerGene2 == "o"))
        {
            g = "she-cat";
        }
        else if(basePairs.Any(x => x.gene2.name == "y")  )
        {
            g = "tom";
        }
        Genotype genotype = new Genotype(basePairs, g);
        return genotype;
    }
}