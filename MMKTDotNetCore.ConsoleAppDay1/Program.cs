using System.Text;

public class Program
{
    public static void Main(string[] args) // entry point
    {
        int a = 10;
        decimal b = 10.0M;
        float c = 10.0F;
        long phoneNumber = 09773871112;
        string firstName = "Lin Thit";
        string lastName = "Htoo";

        // lastName = "overwritten"; // reassigning value

        int result = 1 + 1; // int

        //StringBuilder stringBuilder = new();
        //stringBuilder.Append("Lin Thit");
        //stringBuilder.Append(" Htoo");
        //Console.WriteLine(stringBuilder.ToString());

        // concatenate
        string fullName = firstName + " " + lastName;
        Console.WriteLine(fullName);

        // Your Full Name is:
        // interpolation
        Console.WriteLine($"Your Full Name is: {fullName}");
        Console.WriteLine("Your Full Name is: {0}", fullName);
    }

    public static async Task RunAsync() // void
    {
        await Task.Delay(100);
    }
}