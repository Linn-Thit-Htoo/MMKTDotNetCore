public class Program
{
    public static void Main(string[] args)
    {
        //int number = 10;
        //string str = number.ToString();
        //string str1 = Convert.ToString(number);

        //Guid id = Guid.NewGuid();
        //string userId = id.ToString();
        //Console.WriteLine(userId);

        //string amount = "10000";
        //decimal finalAmount = Convert.ToDecimal(amount);

        //Console.WriteLine(finalAmount);

        Console.WriteLine("Please enter your email: ");
        string? email = Console.ReadLine();

        #region Technique 1

        //if (string.IsNullOrEmpty(email))
        //{
        //    Console.WriteLine("Invalid email.");
        //}
        //else
        //{
        //    Console.WriteLine($"Your input email: {email}");
        //}

        #endregion

        #region Technique 2

        //if (string.IsNullOrEmpty(email))
        //{
        //    Console.WriteLine("Invalid email.");
        //    return;
        //}

        //Console.WriteLine($"Your input email: {email}");

        #endregion

        #region Technique 3

        bool isValidEmail = !string.IsNullOrEmpty(email);
        Console.WriteLine(isValidEmail ? $"Your input email: {email}" : "Invalid email.");

        #endregion

        //int age = 20;
        //string message = age <= 18 ? "Child" : age >= 50 ? "Old" : "Adult";

        //if (age <= 18)
        //{
        //    Console.WriteLine("Child");
        //}
        //else if (age >= 18)
        //{
        //    Console.WriteLine("Adult");
        //}
        //else
        //{
        //    Console.WriteLine("Old");
        //}

        Console.ReadKey();
    }
}