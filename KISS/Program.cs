// See https://aka.ms/new-console-template for more information
namespace KISS;

public class Program
{
    public static void WithoutKISS()
    {
        int item = 2;
        string itemType = "sabun";
        string itemName = "nuvo";
        double diskon = 0;

        if (item > 1)
        {
            if (itemType == "sabun")
            {
                if (itemName == "nuvo")
                {
                    diskon = 50;
                }
            }
            else if (itemType == "mie")
            {
                if (itemName == "indomie")
                {
                    diskon = 30;
                }
            }
        }

        Console.WriteLine("Anda mendapat diskon sebesar {0}", diskon);
    }

    public static void WithKISS()
    {
        int item = 2;
        string itemType = "sabun";
        string itemName = "nuvo";
        double diskon = 0;

        if (item > 1)
        {
            if (itemType == "sabun" && itemName == "nuvo")
            {
                diskon = 50;
            }
            else if (itemType == "mie" && itemName == "indomie")
            {
                diskon = 30;
            }
        }

        Console.WriteLine("Anda mendapat diskon sebesar {0}", diskon);
    }


    public static void Main(string[] args)
    {

        WithKISS();
    }
}
