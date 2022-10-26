using System;

namespace exception_handling
{
    class Program
    {
         static void Main(string[] args)
         {
            /*
            try
            {
                Console.WriteLine("Enter a number:");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number you enter: " +num);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString()); 
            }
            */
            /*
            finally
            {
                Console.WriteLine("The process was completed.");
            }
            */
            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("You entered a null value.");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Data type is not suitable.");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("You entered a very big value or a very small value.");
                Console.WriteLine(ex);
            }
            finally{
                Console.WriteLine("The process was completed successfully.");
            }

         }
    }
}