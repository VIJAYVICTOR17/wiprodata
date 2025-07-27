using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class FilterExp
    {
        static void FilterData(string name)
        {
            string filter = "";
            if (name.Length<3)
            {
                filter= "small";
            }
            else if (name.Length>3 && name.Length<8)
            {
                filter = "mid";
            }
            else if (name.Length >= 9 && name.Length<11)
            {
                filter = "big";
            }
            if (filter == "samll")
            {
                throw new FilterException("The name is small range");
            }
            else if (filter == "mid")
            {
                throw new FilterException("The name mid range");
            }
            else if (filter == "big")
            {
                throw new FilterException("The name is too big");
            }
            else
            {
                throw new FilterException("This is invalid");
            }
        }
        static void Main()
        {
            string name;
            Console.WriteLine("Enter your name : ");
            name = Console.ReadLine();
            try
            {
                FilterData(name);
            }
            catch (FilterException e) when (e.Message.Contains("small"))
            {

                Console.WriteLine(e.Message);
            }
            catch (FilterException e) when (e.Message.Contains("mid"))
            {
                Console.WriteLine(e.Message);
            }
            catch (FilterException e) when (e.Message.Contains("big"))
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
