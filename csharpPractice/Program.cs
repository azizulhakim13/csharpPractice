namespace MyCsharpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Not have new line");
            Console.WriteLine("Hello World");
            Console.WriteLine("nothing");

            // Escape Sequence
            /*
             * \b \t
            */

            // ====>>>>> Variables & data types
            int x;   // Declaration
            x = 1;
            double y = 2.5;
            double result = x + y;
            bool alive = true;

            Console.WriteLine("The result is: " + result);
        }
    }
}
