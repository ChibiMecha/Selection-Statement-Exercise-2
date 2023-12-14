namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            // var r = new Random();
            // var favNumber = r.Next(1, 10);
            // int userInput;
            // do
            // {
            //     Console.WriteLine("Try to guess my favorite number 1-10");
            //     userInput = int.Parse(Console.ReadLine());
            
            //     if (userInput < favNumber)
            //     {
            //     Console.WriteLine("Too Low");
            //     }
            //     else if (userInput > favNumber)
            //     {
            //     Console.WriteLine("Too High");
            //     }
            //     else
            //     {
            //     Console.WriteLine("You guessed it!!!");
            //     }
            // } while (userInput != favNumber);

            //Exercise 2
            Console.WriteLine("What is your favorite school subject?\nChoose between the following:\nMath\nScience\nHistory\nEnglish\nGym");
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