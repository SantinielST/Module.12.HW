namespace Module._12.HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users = { new User { Name = "Pavel", IsPremium = true }, new User { Name = "Viktor", IsPremium = false } };
            users.Greetings();
        }
    }
}

