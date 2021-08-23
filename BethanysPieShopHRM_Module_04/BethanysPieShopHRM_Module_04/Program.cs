using System;
using System.ComponentModel.Design;
using System.Text;

namespace BethanysPieShopHRM_Module_04
{
    class Program
    {
        static void Main(string[] args)
        {

            // string noValueString = null;
            //
            // string s;
            //
            // s = fullName;
            //
            // var userName = "BethanyS";

            string firstName = "Bethany";
            string lastName = "Smith";

            // System.String fullName = "Bethany Smith";
            string fullName = firstName + " " + lastName;
            string employeeIdentification = string.Concat(firstName, lastName);
            string empID = firstName.ToLower() + "-" + lastName.Trim().ToLower();

            int length = empID.Length;

            if (fullName.Contains("beth") || fullName.Contains("Beth"))
            {
                Console.WriteLine("It's Bethany!");
            }

            string subString = fullName.Substring(1, 3);
            Console.WriteLine("Characters 2 to 4 of fullName are " + subString);

            string nameUsingInterpolation = $"{firstName}-{lastName}";
            Console.WriteLine(nameUsingInterpolation);

            string greeting = $"Hello {firstName}!";
            Console.WriteLine(greeting.ToLower());

            string displayName = $"Welcome!\n{firstName}\t{lastName}";
            Console.WriteLine(displayName);

            string invalidFilePath = "C:\\data\\employeelist.xlsx";

            string marketingTagLine = "Baking the \"best pies\" ever";

            string verbatimFilePath = @"C:\data\employeelist.xlsx";

            Console.WriteLine(invalidFilePath);
            Console.WriteLine(marketingTagLine);
            Console.WriteLine(verbatimFilePath);

            string name1 = "Bethany";
            string name2 = "BETHANY";

            Console.WriteLine("Are both names equal? " + (name1 == name2));
            Console.WriteLine("Is name equal to Bethany? " + (name1 =="Bethany"));
            Console.WriteLine("Is name equal to BETHANY? " + name2.Equals("BETHANY"));
            Console.WriteLine("Is lower name equal to bethany? " + (name1.ToLower() == "bethany"));

            string name = "Bethany";
            string anotherName = name;

            name += "Smith";

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Another name: " + anotherName);

            string lowerCaseName = name.ToLower();

            string indexes = string.Empty;
            for (int i = 0; i < 2500; i++)
            {
                indexes += i.ToString();
            }

            // Console.WriteLine(indexes);

            StringBuilder builder = new StringBuilder();

            builder.Append("Last Name: ");
            builder.AppendLine(lastName);
            builder.Append("First Name: ");
            builder.Append(firstName);
            string result = builder.ToString();

            Console.WriteLine(result);

            Console.WriteLine("Enter the wage:");
            string wage = Console.ReadLine();

            // int wageValue = int.Parse(wage);

            int wageValue;
            if (int.TryParse(wage, out wageValue))
            {
                Console.WriteLine("Parsing success: " + wageValue);
            }
            else
            {
                Console.WriteLine("Parsing failed");
            }



            Console.ReadLine();

        }
    }
}
