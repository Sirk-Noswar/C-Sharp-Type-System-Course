using System;

namespace BethanysPieShopHRM_Module_5
{
    class Program
    { 
        static void Main(string[] args)
        {

            int monthlyWage = 1234;
            int months = 12;
            int bounus = 1000;

            //int yearlyWage = CalculateYearlyWage(monthlyWage, months, bounus);

            //Console.WriteLine($"Yearly wage (from main): {yearlyWage}");

            double monthlyWageDouble = 1500.0;
            double monthsDouble = 12;
            double bonusDouble = 1000;
            //double yearlyWageWithBonusDouble = CalculateYearlyWage(monthlyWageDouble, monthsDouble, bonusDouble);

            //UsingValueParameters();
            //UsingRefParameters();
            //UsingOutParameters();
            UsingParams();

            Console.ReadLine();
        }

        //public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        //{
        //    //Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
        //    if (numberOfMonthsWorked == 12)
        //    {
        //        return monthlyWage * (numberOfMonthsWorked + 1);
        //    }
        //    return monthlyWage * numberOfMonthsWorked;
        //}

        //public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        //{
        //    Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
        //    return monthlyWage * numberOfMonthsWorked + bonus;
        //}

        //public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus)
        //{
        //    Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
        //    return monthlyWage * numberOfMonthsWorked + bonus;
        //}

        //public static void UsingValueParameters()
        //{
        //    int monthlyWage1 = 1234;
        //    int monthlyWage2 = 2000;
        //    int months1 = 12;
        //    int months2 = 8;
        //    int bonus = 300;

        //    int yearlyWageForEmloyee1 = CalculateYearlyWage(monthlyWage1, months1, bonus);
        //    Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForEmloyee1}");

        //    int yearlyWageForEmployee2 = CalculateYearlyWage(monthlyWage2, months2, bonus);
        //    Console.WriteLine($"Yearly wage for employee 2 (John): {yearlyWageForEmployee2}");
        //}

        //public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        //{

        //    if (monthlyWage < 2000)
        //    {
        //        bonus *= 2;
        //    }

        //    Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
        //    Console.WriteLine($"The employee got a bonus of {bonus}");
        //    return monthlyWage * numberOfMonthsWorked + bonus;
        //}

        //private static void UsingRefParameters()
        //{
        //    int monthlyWage1 = 1234;
        //    int monthlyWage2 = 2000;
        //    int months1 = 12;
        //    int months2 = 8;
        //    int bonus = 300;

        //    int yearlyWageForEmployee1ByRef = CalculateYearlyWageByRef(monthlyWage1, months1, ref bonus);
        //    Console.WriteLine($"Yearly wage for employee 1 (Bethany: {yearlyWageForEmployee1ByRef}");
        //    Console.WriteLine($"Employee 1 received a bonus of {bonus}");

        //    int yearlyWageforEmployee2ByRef = CalculateYearlyWageByRef(monthlyWage2, months2, ref bonus);
        //    Console.WriteLine($"Yearly wage for employee 2 (John): {yearlyWageforEmployee2ByRef}");
        //    Console.WriteLine($"Employee 2 received a bonus of {bonus}");
        //}

        //public static int CalculateYearlyWageByRef(int monthlyWage, int numberOfMonthsWorked, ref int bonus)
        //{
        //    if (monthlyWage < 2000)
        //    {
        //        bonus *= 2;
        //        Console.WriteLine("Bonus doubled!! Yay!!");
        //    }
        //    Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
        //    return monthlyWage * numberOfMonthsWorked + bonus;

        //}

        public static void UsingOutParameters()
        {
            int monthlyWage1 = 1234;
            int months1 = 12;
            int bonus;

            int yearlyWageForEmployee1 = CalculateYearlyWageWithOut(monthlyWage1, months1, out bonus);
            Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForEmployee1}");
            Console.WriteLine($"Bethany received a bonus of {bonus}");
        }

        public static int CalculateYearlyWageWithOut(int monthlyWage, int numberOfMonthsWorked, out int bonus)
        {
            bonus = new Random().Next(1000);
            if (bonus < 500)
            {
                bonus *= 2;
                Console.WriteLine("Bonus doubled!! Yay!!");
            }

            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        private static void UsingParams()
        {
            int monthlyWage1 = 1000, monthlyWage2 = 1234, monthlyWage3 = 1500, monthlyWage4 = 2500;

            int average = CalculateAverageWage(monthlyWage1, monthlyWage2, monthlyWage3, monthlyWage4);
            Console.WriteLine($"The average wage is {average}");
        }

        private static int CalculateAverageWage(params int[] wages)
        {
            int total = 0;
            int numberOfWages = wages.Length;

            for (int i = 0; i < numberOfWages; i++)
            {
                total += wages[i];
            }

            return total / numberOfWages;
        }

    }
}
