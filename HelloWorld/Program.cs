namespace MyProgram
{
    class MyProgram
    {
        private string model;
        private string colour;
        private int year;

        static int AddNums(int x, int y)
        {
            return x + y;
        }

        static double AddDoubleNums(double x, double y)
        {
            return x + y;
        }

        static void CarMapper(object obj)
        {
            Type type = obj.GetType();
            var properties = type.GetProperties();
            
            foreach (var item in properties)
            {
                Console.WriteLine($"{item.Name}");
                // Console.WriteLine($"{item.GetValue(obj)}");
            }
        }

        static void Main(string[] args)
        {
            // double myNum = 15.55453426472674;

            // Console.WriteLine("Enter num to display: ");
            // int myNum = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"You entered: {myNum}");

            // int[] myNumbers = {5, 1, 8, 9};
            // Console.WriteLine(myNumbers.Max());  // returns the largest value
            // Console.WriteLine(myNumbers.Min());  // returns the smallest value
            // Console.WriteLine(myNumbers.Sum());  // returns the sum of elements


            // int addIntResult = AddNums(3, 5);
            // Console.WriteLine($"add int result: {addIntResult}");
            // double addDoubleResult = AddDoubleNums(3.0, 5.0);
            // Console.WriteLine($"add int result: {addDoubleResult}");

            // MyProgram program = new MyProgram();
            // Console.WriteLine(program.colour);

            MyProgram car1 = new MyProgram();
            car1.colour = "red";
            car1.model = "ferrari";
            car1.year = 2019;

            MyProgram car2 = new MyProgram();
            car2.colour = "yellow";
            car2.model = "porsche";
            car2.year = 2011;
            
            // CarMapper(car1)?;
            Console.WriteLine(car1.colour);
            Console.WriteLine(car1.model);
            Console.WriteLine(car1.year);
            
            Console.WriteLine(car2.colour);
            Console.WriteLine(car2.model);
            Console.WriteLine(car2.year);
            
        }
    }
}