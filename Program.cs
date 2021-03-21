using System;

namespace Marks_sheet
{
    class Program
    {
        static void Main(string[] args)
        {
            int urdu,english,maths,islamic,pakstudies,obt;
            Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Roll number:");
            string rollnum = Console.ReadLine();
            Console.WriteLine("Enter your Class");
            string clas = Console.ReadLine();
            Console.WriteLine("Enter your Urdu Marks:");
            urdu = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your English Marks:");
            english = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Mathematics Marks:");
            maths = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Islamic Studies Marks:");
            islamic = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Pakistan Studies Marks:");
            pakstudies = int.Parse(Console.ReadLine());

            obt = urdu + maths + english + islamic + pakstudies;
             double per =obt * 100 / 500;

            Console.WriteLine("Your Name is {0}", name);


            Console.WriteLine("Your Class is {0}", clas);

            Console.WriteLine("Your Roll Number is {0}", rollnum);
            Console.WriteLine("Total Marks are {0}", obt);
            Console.WriteLine("Your Percentage {0} %", per);


            if (per >= 80 && per <= 100)
            {
                Console.WriteLine("Your Grade is : A");
                Console.WriteLine("Remarks: Exceptional");
            }
            else if (per >= 70 && per < 80)
            {
                Console.WriteLine("Your Grade is : -A");
                Console.WriteLine("Remarks: Excellent");
            }
            else if(per >= 60 && per < 70)
            {
                Console.WriteLine("Your Grade is : B");
                Console.WriteLine("Remarks: Good");
            }
            else if (per >= 50 && per < 60)
            {
                Console.WriteLine("Your Grade is : C");
                Console.WriteLine("Remarks: Need Improvement");
            }
            else if(per == 33)
            {
                Console.WriteLine("You have passed the exams.");
                Console.WriteLine("Remarks: Need to work hard");
            }
            else
            {
                Console.WriteLine("Your Grade is F (Fail).");
                Console.WriteLine("Remarks: Bring your parents tomorrow");
            }
            byte compartments=0;
            if(urdu<33)
            {
                compartments++;
            }
            if (english < 33)
            {
                compartments++;
            }
            if (maths < 33)
            {
                compartments++;
            }
            if (islamic < 33)
            {
                compartments++;
            }
            if (pakstudies < 33)
            {
                compartments++;
            }
            Console.WriteLine("You failed in {0} subject(s)", compartments);

        }
    }
}
