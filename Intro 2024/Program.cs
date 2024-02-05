using Intro_2024.Business;
using Intro_2024.Entities;

namespace Intro_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string message = "Krediler";
            int term = 12;
            double amount = 100000;

            //variables -->camelCase
            bool isAuthenticated = false;//backend'ten gelen data.
            Console.WriteLine(message);

            //condition
            if (isAuthenticated == true)
            {
                Console.WriteLine("Hoşgeldin Engin");
            }
            else
            {
                Console.WriteLine("Sisteme giriş yap");
            }

            //string kredi1 = "Kredi 1";
            //string kredi2 = "Kredi 2";
            //string kredi3 = "Kredi 3";
            //string kredi4 = "Kredi 4";
            //string kredi5 = "Kredi 5";

            //array
            string[] loans = { "Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5" };

            //string[] loans2 = new string[6];
            //loans2[0] = "Kredi1";

            //start     //condition    //increment
            for (int i = 0; i < loans.Length; i++)
            {
                Console.WriteLine(loans[i]);
            }

            foreach (var loan in loans)
            {
                Console.WriteLine(loan);
            }



            //Course[] courses = { course1, course2, course3 };



            CourseManager courseManager = new();
            Course[] courses2 = courseManager.GetAll();

            for (int i = 0; i < courses2.Length; i++)
            {
                Console.WriteLine(courses2 + " / " + courses2[i].Price);
            }

            Console.WriteLine("kod bitti");
        }
    }
}