namespace Module._12.HW;

static class Greeter
{
    public static void Greetings(this User[] users) 
    {
        foreach (var user in users)
        {
            if (!user.IsPremium)
            {
                ShowAds();
            }
        
            Console.WriteLine($"Добрый день, {user.Name}!");
            Console.WriteLine();
        }
    }

    private static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        // Остановка на 1 с
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        // Остановка на 2 с
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        // Остановка на 3 с
        Thread.Sleep(3000);
    }
}
