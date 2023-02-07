// See https://aka.ms/new-console-template for more information

using src2;

class Program
{
    static void Main(string[] args)
    {
        //8
        ClsClothing c1 = new WinterCloth()
        {
            Name = "חולצה מכופתרת", Price = 55, Month = 2,
            Materials = new List<ClsMaterial>()
            {
                new ClsMaterial()
                    { NameM = "פשתן", PresentM = 50 }
            },
            Ona = EOna.Summer, Rainproof = false
        };

        ClsClothing c2 = new WinterCloth()
        {
            Name = "מכנס", Price = 66, Month = 5,
            Materials = new List<ClsMaterial>()
            {
                new ClsMaterial()
                    { NameM = "פוליאסטר", PresentM = 50 },
                new ClsMaterial()
                    { NameM = "צמר", PresentM = 50 }
            },
            Ona = EOna.Winter, Rainproof = false
        };

        ClsClothing c3 = new WinterCloth()
        {
            Name = "מעיל", Price = 77, Month = 6,
            Materials = new List<ClsMaterial>()
            {
                new ClsMaterial()
                    { NameM = "צמר", PresentM = 50 },
                new ClsMaterial()
                    { NameM = "פוליאסטר", PresentM = 50 }
            },
            Ona = EOna.Winter, Rainproof = true
        };

        ClsClothing c4 = new WinterCloth()
        {
            Name = "גרביים", Price = 88, Month = 8,
            Materials = new List<ClsMaterial>()
            {
                new ClsMaterial()
                    { NameM = "כותנה", PresentM = 90 }
            },
            Ona = EOna.Winter, Rainproof = false
        };

        ClsClothing c5 = new WinterCloth()
        {
            Name = "חצאית פליסה", Price = 100, Month = 2,
            Materials = new List<ClsMaterial>()
            {
                new ClsMaterial()
                    { NameM = "פשתן", PresentM = 70 },
                new ClsMaterial()
                    { NameM = "צמר", PresentM = 30 }
            },
            Ona = EOna.Summer, Rainproof = false
        };

        Console.WriteLine(c1.Equals(c5));
        List<ClsClothing> cls = new List<ClsClothing>() { c1, c2, c3, c4, c4 };

        //9
        if (cls[2] is IShaatnez)
            if ((cls[2] as IShaatnez).IShaatnez())
                cls.RemoveAt(2);

        cls.Sort();
        Console.ReadLine();
    }
}

