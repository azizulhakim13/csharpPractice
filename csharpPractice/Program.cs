namespace MyCsharpProgram
{
    class Program
    {
        // =======>>>>> Method
        static void Message(string name, int age)
        {
            Console.WriteLine("Hello: " + name + ", you're: " + age);
        }

        static void Main(string[] args)
        {
            // =====>>>> Method Calling
            string yourName = "John";
            int yourAge = 30;
            Message(yourName, yourAge);


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


            ////======>>>>>>>> If Statement, Logical Operator(&&, ||)
            //Console.WriteLine("Please Enter Your Age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age > 18 || age == 18)
            //{
            //    Console.WriteLine("You are now signed up!");
            //}
            //else if (age < 0)
            //{
            //    Console.WriteLine("Born first!");
            //}
            //else
            //{
            //    Console.WriteLine("You Must be 18+ to signup!");
            //}

            //Console.WriteLine("Enter your name: ");
            //string nameUser = Console.ReadLine();
            //if (nameUser == "")
            //{
            //    Console.WriteLine("You haven't entered your name");
            //}
            //else
            //{
            //    Console.WriteLine("Hello " + nameUser);
            //}

            //// Switch case
            //Console.WriteLine("What day is it today?");
            //string day = Console.ReadLine();
            //switch (day)
            //{
            //    case "Monday":
            //        Console.WriteLine("It's Monday!");
            //        break;
            //    case "Tuesday":
            //        Console.WriteLine("It's Tuesday!");
            //        break;
            //    default:
            //        Console.WriteLine(day + " is not day!");
            //        break;
            //}


            ////=======>>>>>>> Loop: While loop => repeat code based on a condition trueConsole.Write("Enter your name: ");
            //string yourName = "";
            //while (yourName == "")
            //{
            //    Console.Write("Enter your name: ");
            //    yourName = Console.ReadLine();
            //}
            //Console.WriteLine("Hello " + yourName);

            //// For loop
            //for (int index = 1; index <= 10; index += 2)
            //{
            //    Console.Write(index + "/");
            //}

            //for (int yy = 10; yy > 0; yy -= 2)
            //{
            //    Console.Write(yy);
            //}

            // nested loop
            //Console.Write("How many Rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //Console.Write("How many columns: ");
            //int columns = Convert.ToInt32(Console.ReadLine());

            //Console.Write("What is the Symbol: ");
            //string symbol = Console.ReadLine();

            //for (int a = 0; a < rows; a++)
            //{
            //    for (int ab = 0; ab < columns; ab++)
            //    {
            //        Console.Write(symbol);
            //    }
            //    Console.WriteLine();
            //}


            // ====>>>> Array
            string[] cars = { "Toyota", "Volvo", "Hyundai" };
            for (int count = 0; count < cars.Length; count++)
            {
                Console.Write(cars[count] + ", ");
            }

            // Iterating array with foreach
            foreach (string car in cars)
            {
                Console.Write(car + ", ");
            }

            // Fixed sized array
            string[] fruits = new string[2];
            fruits[0] = "Mango";

            //Sum of all elements in an array
            int[] numbers = { 2, 4, 7, 8, 9, 10, 11 };
            int sum = 0;
            foreach (int number in numbers)
            {
                sum = sum + number;
            }
            Console.WriteLine(sum);

            //find the maxiumum number in an array
            int[] numbers2 = { 4, 7, 8, 9, 3, 1 };
            int max = numbers2[0];
            for (int count = 1; count < numbers2.Length; count++)
            {
                if (numbers2[count] > max)
                {
                    max = numbers2[count];
                }
            }
            Console.WriteLine(max);

            // find Count of a number
            Console.Write("Write a number to find it's Count: ");
            int findCount = Convert.ToInt32(Console.ReadLine());
            for (int count = 1; count <= 10; count++)
            {
                result = findCount * count;
                Console.WriteLine($"{findCount} × {count} = " + result);
            }


            // ===>>> Method
            double num1;
            double num2;
            double resultMultiplication;
            Console.WriteLine("Enter number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number 1: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            resultMultiplication = Multiply(num1, num2);
            Console.WriteLine(resultMultiplication);
        }

        static double Multiply(double a, double b)
        {
            double z = a * b;
            return z;
        }


    }
}
