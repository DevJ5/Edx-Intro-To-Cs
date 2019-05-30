using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_AssesmentLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] details = GetStudentInformation();
            PrintStudentInformation(details[0], details[1], details[2]);

            try
            {
                ValidateBirthday(new DateTime(1984,6,5));
            }
            catch(NotImplementedException e )
            {
                Console.WriteLine("This method has not been implemented yet." + e);
            }
        }

        static string[] GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your birthdate : YYYY/MM/DD");
            string birthDate = Console.ReadLine();

            return new string[] { firstName, lastName, birthDate};
        }

        static void PrintStudentInformation(string firstName, string lastName, string birthDate)
        {
            string[] birthDateArr = birthDate.Split('/');
            DateTime birthDateTime = new DateTime(Int32.Parse(birthDateArr[0]), Int32.Parse(birthDateArr[1]), Int32.Parse(birthDateArr[2]));
            Console.WriteLine($"First name: {firstName}, Last name: {lastName}, Birthdate: {birthDateTime}");
          
        }

        static bool ValidateBirthday(DateTime birthday)
        {
            throw new NotImplementedException();
        }
    }
}
