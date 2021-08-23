using System;

namespace BethanysPieShopHRM_Module_06
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingEnumerations();

            Console.ReadLine();
        }

        private static void UsingEnumerations()
        {
            EmployeeType employeeType = EmployeeType.Manager;
            StoreType storeType = StoreType.Seating;
            int baseWage = 100;

            CalculateWage(baseWage, employeeType, storeType);
        }

        private static void CalculateWage(int baseWage, EmployeeType employeeType, StoreType storeType)
        {
            int calculatedWage = 0;

            if (employeeType == EmployeeType.Manager)
            {
                calculatedWage = baseWage * 3;
            }
            else
            {
                calculatedWage = baseWage *= 2;
            }

            if (storeType == StoreType.FullPieRestaurant)
            {
                calculatedWage += 500;
            }

            Console.WriteLine($"The calculated wage is {calculatedWage}");
        }

    }

    enum EmployeeType
    {
        Sales,
        Manager,
        Research,
        StoreManager
    }

    enum StoreType
    {
        PieCorner = 10,
        Seating = 20,
        FullPieRestaurant = 100,
        Undefined = 99
    }
}
