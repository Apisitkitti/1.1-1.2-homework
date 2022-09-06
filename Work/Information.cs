public class Information
{
    public string Name ="";
    public long  Number ;
    public string Owner_name = "";
    public long Registered_Value; 
    public static void Information_Print(Information info)
    {
        Console.WriteLine("------------------ Shop Information ------------------");
        Console.WriteLine("\nName: {0}",info.Name);
        Console.WriteLine("Number: {0}",info.Number);
        Console.WriteLine("Owner Name: {0}",info.Owner_name);
        Console.WriteLine("Registered Value: {0}",info.Registered_Value);
        Console.WriteLine("\n-------------------------------");

    }
}

