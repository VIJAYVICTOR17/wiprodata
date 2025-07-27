using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class MilestoneExcepcs
    {
        static void MilestoneInfo(string exam)
        {
            if (exam.Equals("M1"))
            {
                throw new MilestoneExcepMain("Milestone 1 contains .Net");
            }
            else if (exam.Equals("M2"))
            {
                throw new MilestoneExcepMain("Milestone 2 is on C#");
            }
            else if (exam.Equals("M3"))
            {
                throw new MilestoneExcepMain("Milestone 3 is on HTMl and CSS");
            }
            else if  (exam.Equals("M4"))
            {
                throw new MilestoneExcepMain("Milestone 4 is on React");
            }
            else
            {
                throw new MilestoneExcepMain("Invalid entry");
            }
        }
        static void Main()
        {
            string exam;
            Console.WriteLine("Enter your exam");
            exam = Console.ReadLine();
            try
            {
                MilestoneInfo(exam);
            }
            catch (MilestoneExcepMain e) when (e.Message.Contains("Milestone1"))
            {

                Console.WriteLine(e.Message);
            }
            catch (MilestoneExcepMain e) when (e.Message.Contains("Milestone2"))
            {
                Console.WriteLine(e.Message);
            }
            catch (MilestoneExcepMain e) when (e.Message.Contains("Milestone3"))
            {
                Console.WriteLine(e.Message);
            }
            catch (MilestoneExcepMain e) when (e.Message.Contains("Milestone4"))
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
