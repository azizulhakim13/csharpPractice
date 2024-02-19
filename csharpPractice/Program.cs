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
            x = 2;
            double y = 62.50;

            double result = x + y;

            bool alive = true;

            char grade = 'B';  // single char are inside ''

            string name = "John";

            const double pi = 3.1416;

            Console.WriteLine("The marks and grade of " + name + " is: " + result + ", " + grade);

            // ======>>>>>> Type casting: converting a value to different data type
            int b = Convert.ToInt32(result);
            double c = Convert.ToDouble(b);
            string d = Convert.ToString(c);
            char e = Convert.ToChar(x);
            string i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(j.GetType());

            // ====>>>> User Input
            //Console.WriteLine("Whats is Your Name?");
            //string typeName = Console.ReadLine();

            //Console.WriteLine("Whats's Your Age?");
            //int age = Convert.ToInt32(Console.ReadLine());
            //age += 2;
            //Console.WriteLine("Hello " + typeName + ", You are: " + age);

            // =====>>>> Arithmetic operators; +, -, *, /, +=, -=
            double z = Math.Pow(pi, x);
            double round = Math.Round(z);
            Console.WriteLine(round);

            //Generate random number
            Random randomNum = new Random();
            int num = randomNum.Next(1, 41);
            Console.WriteLine(num);

            //Calculating hypotenuse
            //Console.WriteLine("Enter Side A: ");
            //double A = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter side B: ");
            //double B = Convert.ToDouble(Console.ReadLine());
            //double C = Math.Sqrt((A * A) + (B * B));
            //Console.WriteLine(C);


            //======>>>>>>> String methods
            string fullName = "Azizul";
            fullName = fullName.ToUpper();
            Console.WriteLine(fullName);

            string phoneNumber = "123-456-7890";
            phoneNumber = phoneNumber.Replace("-", "");
            Console.WriteLine(phoneNumber);

            string userName = fullName.Insert(0, "Md. ");   //insert
            Console.WriteLine(userName + ", Length: " + userName.Length);
            Console.WriteLine(userName.Substring(0, 5));    // slice of code

        }
    }
}
