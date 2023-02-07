namespace src2;

public enum EOna
{
    Winter,
    Summer
}
 class WinterCloth :ClsClothing, IShaatnez
{
    public int Month{ get; set; }
    public EOna Ona{ get; set; }
    public bool Rainproof { get; set; } = true;
    
    //1
    public override int Discount()
    {
        if (Month >= 3 && Month <= 10)
            //return base.Discount();
         return Discount(EOna.Winter);
        else
          //  return base.Discount() + 10 ;
        return Discount(EOna.Summer);
    }

    //2
    public int Discount(EOna ona)
    {
        switch (ona)
        {
            case EOna.Winter:
                return base.Discount();
            case EOna.Summer:
                return base.Discount() + 10;
        }
        return 0;
    }

    //4
    public bool IShaatnez()
    {
        int counter = 0;
        foreach (var item in Materials)
        {
            if (item.NameM == "פשתן" || item.NameM == "צמר")
                counter++;
        }
        // if (counter == 2)
        //    return true;
        //return false;
        return counter == 2;
    }
}

