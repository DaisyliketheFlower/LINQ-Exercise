namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGamesList = new List<string> { "callofduty", "tekken", "godofwar", "grandtheftauto" };

            Console.WriteLine("Original List");

            videoGamesList.ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("Ordered List:");
            videoGamesList.OrderBy(name => name.Length).ToList().ForEach(gameName => Console.WriteLine(gameName));
        }

             
    }       
    }   






          

