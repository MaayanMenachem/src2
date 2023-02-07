namespace src2;

class ClsClothing 
{
    public string Name { get; set; }
    public int YearOfManufacture { get; set; } = DateTime.Today.Year;
    public List<ClsMaterial>? Materials { get; set; }
    public int Price { get; set; }

    public ClsClothing()
    {
        YearOfManufacture = DateTime.Today.Year;
    }

    //1
    public virtual int Discount()
    {
        if (YearOfManufacture < DateTime.Today.Year)
            return (DateTime.Today.Year - YearOfManufacture) * 5;
        else
            return 0;
    }
    
    //5
    public static ClsClothing CheapestCloth(List<ClsClothing> clc)
    {
        ClsClothing Min = clc[0];
        for (int i = 1; i < clc.Count(); i++)
        {
            if (Min.Price > clc[i].Price)
                Min = clc[i];
        }
        return Min;
    }
    
    //7
    public override bool Equals(object Obj)
    {
        if (Obj is ClsClothing)
        {
            ClsClothing b = Obj as ClsClothing;
            return (Name.Equals(b.Name) && YearOfManufacture == b.YearOfManufacture);
        }
        throw new Exception("לא שלחת בגד להשווה");
    }

    public int CompareTo(object Obj)
    {
        if (Obj is ClsClothing)
            return Price.CompareTo((Obj as ClsClothing).Price);
        throw new Exception("לא שלחת בגד");
    }

    public override string ToString()
    {
        return "Name" + Name + "," + "YearOfManufacture" + YearOfManufacture;
    }
}