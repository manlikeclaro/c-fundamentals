namespace MyProgram
{
    class MyProgram
    {
        static void Main()
        {
            // double myNum = 15.55453426472674;

            // Console.WriteLine("Enter num to display: ");
            // int myNum = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"You entered: {myNum}");

            // int[] myNumbers = {5, 1, 8, 9};
            // Console.WriteLine(myNumbers.Max());  // returns the largest value
            // Console.WriteLine(myNumbers.Min());  // returns the smallest value
            // Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

            // static void MyMethod(string child1, string child2 , string child3 = "darryl")
            // {
            //     Console.WriteLine("The youngest child is: " + child3);
            //     Console.WriteLine(child3);
            // }

            static int AddNums(int x, int y)
            {
                return x + y;
            }
            
            static double AddDoubleNums(double x, double y)
            {
                return x + y;
            }

            static void Main(string[] args)
            {
                int addIntResult = AddNums(3, 5);
                Console.WriteLine($"add int result: {addIntResult}");
                double addDoubleResult = AddDoubleNums(3.0, 5.0);
                Console.WriteLine($"add int result: {addDoubleResult}");
            }
        }
    }
}