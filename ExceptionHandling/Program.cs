using System;

// Page 143

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Dividing the two...");
                int num3 = num1 / num2;
                Console.WriteLine(num1 + " / " + num2 + " = " + num3);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Only enter numbers, please.\nError: " + ex.Message);
                return;     // This will end the program unless you have 'finally'
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("YOU CAN'T DIVIDE BY ZERO!\nError: " + ex.Message);
            }
            catch(Exception ex)     // Catches any general exception
            {
                Console.WriteLine("Something went wrong...\nError: " + ex.Message);
            }
            finally     // No matter what happens, this code will run.
            {
                Console.Read();
            }

            Console.WriteLine("This will not show up if you do a FormatException because of the return statement");
            Console.Read();
        }
    }
}
