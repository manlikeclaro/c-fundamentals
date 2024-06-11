namespace MyProgram
{
    class MyProgram
    {
        static void Main()
        {
            // double myNum = 15.55453426472674;
            
            Console.WriteLine("Enter num to display: ");
            int myNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You entered: {myNum}");
        }   
    }
}