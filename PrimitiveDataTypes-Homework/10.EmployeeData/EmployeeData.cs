using System;



    class EmployeeData
    {
        static void Main()
        {
        //    A marketing company wants to keep record of its employees. Each record would have the following characteristics:

        //    First name
        //    Last name
        //    Age (0...100)
        //    Gender (m or f)
        //    Personal ID number (e.g. 8306112507)
        //    Unique employee number (27560000…27569999)
        //    Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.


            Console.WriteLine("Your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Your age: ");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Your gender - m or f: ");
            char gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Your personal ID number: ");
            long personalIdNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Your unique number: ");
            long uniqueNumber = long.Parse(Console.ReadLine());

            Console.WriteLine("Checking information...");
            Console.WriteLine("Employee first name is {0}", firstName);
            Console.WriteLine("Employee last name is {0}", lastName);
            Console.WriteLine("Employee age {0}", age);
            Console.WriteLine("Employee gender {0}", gender);
            Console.WriteLine("Employee personal ID number  {0}", personalIdNumber);
            Console.WriteLine("Employee unique number {0}", uniqueNumber);
        }
    }

