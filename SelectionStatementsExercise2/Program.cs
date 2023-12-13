namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?\nChoose between the following:\nMath\nScience\nHistory\nEnglish|Gym");
            string subject = Console.ReadLine();

            switch (subject)
            {
                case"math":
                    Console.WriteLine("I Hate Math");
                    break;
                case "science":
                    Console.WriteLine("Still Not Math");
                    break;
                case "english":
                    Console.WriteLine("ewwwwwww");
                    break;
                case "history":
                    Console.WriteLine("Why not math?");
                    break;
                case "gym":
                    Console.WriteLine("MEATHEAD!!!!");
                    break;
                default:
                    Console.WriteLine("Should have chosen math");
                    break;
            }
        }
    }
}