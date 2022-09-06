using System;
public class Program
{
    public static void Main(string[] args)
    {
        Information Info = new Information();

        Console.Write("Please input Name: ");
        Info.Name = Pls_input();
        Console.Write("Please input Number: ");
        Info.Number = StringtoLong(Pls_input());
        Console.Write("Please input Owner Name: ");
        Info.Owner_name = Pls_input();
        Console.Write("Please input Registered Value: ");
        Info.Registered_Value = StringtoLong(Pls_input());
        Information.Information_Print(Info);
        Console.Write("Please input money: ");
        string Money_real =Pls_input();
        double StringToDoubleChange = StringtoDouble(Money_real);
        Calculator.Money_Thousand(StringToDoubleChange);
        
    }

    public static long StringtoLong(string Input)
    {
        if(long.TryParse(Input,out long ans))
        {
            return ans;
        }
        throw new Exception("Pls Input again");
    }
    public static double StringtoDouble(string Input)
    {
        if(double.TryParse(Input,out double ans))
        {
            return ans;
        }
        throw new Exception("Pls Input again");
    }
    
    public static string Pls_input()
    {
        return Console.ReadLine();
    }
    
        

}


