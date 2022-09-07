public class Calculator
{
    
public static void Money_Thousand(double cash)
    {
        int i;
        for(i =0 ; Thousand_Check(cash); i++)
        {
            cash = cash-1000;

        }
       Console.WriteLine("1000: {0}",i);
       Money_Five_Hundred(cash);
       
    }
    public static void Money_Five_Hundred(double Money)
    {
        int i;
        for(i =0 ; FiveHundred_Check(Money); i++)
        {
            Money = Money-500;

        }
        Console.WriteLine("500: {0}",i);
       Money_Hundred(Money);
    }
    public static void  Money_Hundred(double Money)
    {
        int i;
        for(i =0 ; Hundred_Check(Money); i++)
        {
            Money = Money-100;

        }
      Console.WriteLine("100: {0}",i);
        Money_Fifty(Money);
       
    }
    public static void Money_Fifty(double Money)
    {
        int i;
        for(i =0 ; Fifty_Check(Money); i++)
        {
            Money = Money-50;

        }
       Console.WriteLine("50: {0}",i);
       Money_Twenty(Money);
    }
     
     public static void Money_Twenty(double Money)
    {
        int i;
        for(i =0 ; Twenty_Check(Money); i++)
        {
            Money = Money-20;

        }
       Console.WriteLine("20: {0}",i);
       Money_Ten(Money);
    }
    public static void Money_Ten(double Money)
    {
        int i;
        for(i =0 ; Ten_Check(Money); i++)
        {
            Money = Money-10;

        }
        Console.WriteLine("10: {0}",i);
       Money_Five(Money);
    }
     public static void Money_Five(double Money)
    {
        int i;
        for(i =0 ; Five_Check(Money); i++)
        {
            Money = Money-5;

        }
        Console.WriteLine("5: {0}",i);
       Money_two(Money);
       
    }
    public static void Money_two(double Money)
    {
        int i;
        for(i =0 ; Two_Check(Money); i++)
        {
            Money = Money-2;

        }
        Console.WriteLine("2: {0}",i);
       Money_one(Money);
       
    }
    public static void Money_one(double Money)
    {
        int i;
        for(i =0 ; One_Check(Money); i++)
        {
            Money = Money-1;

        }
        Console.WriteLine("1: {0}",i);
       Money_PointFive(Money);
    }
    public static void Money_PointFive(double Money)
    {
        int i;
        for(i =0 ; PointFive_Check(Money); i++)
        {
            Money = Money-0.5;

        }
        Console.WriteLine(".5 : {0}",i);
       Money_PointtwoFIve(Money);
    }
    public static void Money_PointtwoFIve(double Money)
    {
        int i;
        for(i =0 ; PointTwoFive_Check(Money); i++)
        {
            Money = Money-0.25;

        }
       Console.WriteLine(".25: {0}",i);
       
    }

    public static bool Thousand_Check(double logic)
    {
        return logic >= 1000;
    }
     public static bool FiveHundred_Check(double logic)
    {
        return logic < 1000 && logic >=500;
    }
    public static bool Hundred_Check(double logic)
    {
        return logic < 500 && logic >=100;
    }
     public static bool Fifty_Check(double logic)
    {
        return logic < 100 && logic >=50;
    }
    public static bool Twenty_Check(double logic)
    {
        return logic < 50 && logic >=20;
    }
    public static bool Ten_Check(double logic)
    {
        return logic < 20 && logic >=10;
    }
     public static bool Five_Check(double logic)
    {
        return logic < 10 && logic >=5;
    }
    public static bool Two_Check(double logic)
    {
        return logic < 5 && logic >=2;
    }
    public static bool One_Check(double logic)
    {
        return logic < 2 && logic >=1;
    }
    public static bool PointFive_Check(double logic)
    {
        return logic < 1 && logic >=0.5;
    }
    public static bool PointTwoFive_Check(double logic)
    {
        return logic < 0.5 && logic >=0.25;
    }
}


