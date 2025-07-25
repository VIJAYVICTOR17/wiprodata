using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Division
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Enter x and y values : ");
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                z = x / y;
                Console.WriteLine("The resulted output is : " +z);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Can't be divided with 0");
            }
            catch (FormatException e)
            {
                Console.WriteLine("string can't be converted as integer");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("number is too big.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("The values have a values ");
            }
            
        }
    }
}
