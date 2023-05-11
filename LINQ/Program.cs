namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>
            {
                "Bioshock", "Halo", "Forza", "Grand Theft Auto", "Mario Kart"
            };

            var gameNames = videoGames.OrderBy(name => name.Length);

            foreach(var game in gameNames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
