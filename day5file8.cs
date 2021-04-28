using System;
//Write a program in C# Sharp to create a nested structure to store two data for an employee in an array
    public class structure
    {
        struct employee
        {
            public string Name;
            public DateTime Date;
        }
        struct DateTime
        {
            public int Day;
            public int Month;
            public int Year;
        }  
        public static void Main(string[] args)
        {
            employee[] emp = new employee[2];
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Name of the employee : ");
                string nm = Console.ReadLine();
                emp[i].Name = nm;
                Console.Write("Enter your Employee Id : ");
				Console.Write("Day of the birth : ");
                int dd = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Day = dd;
                Console.Write("Month of the birth : ");
                int mm = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Month = mm; 
                Console.Write("Year for the birth : ");
                int yy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                emp[i].Date.Year = yy;
	          Console.WriteLine("DOB of " +nm+ " is "  +String.Format(dd+"/"+mm+"/"+yy));
	           Console.WriteLine("\n---------------------------------------------------------");
            }
        }
    }