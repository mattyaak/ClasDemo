using System;

namespace ClasDemo
{
    class Staff
    {
        // Fields
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;
        
        //Properties
        public int HoursWorked 
        
        { 
            get
            {
                return hWorked;
            }
            set
            {
                if (value > 0)
                    hWorked = value;
                else
                    hWorked = 0;
            }
        } 
        
        //Methods
        public void PrintMessage()
        {
            Console.WriteLine("Calculating Pay...");
        }

        public int CalculatePay()
        {
            PrintMessage();

            int staffPay;
            staffPay = hWorked * hourlyRate;

            if (hWorked > 0)
                return staffPay;
            else
                return 0;

        }
        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();

            if (hWorked > 0)
                return hWorked * hourlyRate + bonus + allowance;
            else
                return 0;
        }

        public override string ToString()
        {
            return "Name of Staff = " + nameOfStaff + ", hourlyRate = " + hourlyRate + ", hWorked = " + hWorked;
        }
        
        //Constructors
        public Staff (string name)
        {
            nameOfStaff = name;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("------------------");
        }

        public Staff (string firstname, string lastname)
        {
            nameOfStaff = firstname + " " + lastname;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("------------------");

        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an object iE: ClassName objectName = new ClassName(arguments)

            int pay;
            Staff staff1 = new Staff("Peter");
            staff1.HoursWorked = 160;
            pay = staff1.CalculatePay(1000, 400);
            Console.WriteLine("Pay = {0}", pay);

            Staff staff2 = new Staff("Tom");
            /*  staff2.HoursWorked = 100; */
            pay = staff2.CalculatePay();
            Console.WriteLine(pay);

        }
            /* int result = 79;
            Console.WriteLine("{0}! You scored {1} marks for your test. " , "Good morning", result); */

            class MyClass

        {
            //Non static members

            public string message = "Hello, World!";
            public string Name { get; set; }
            public void DisplayName()
            {
                Console.WriteLine("Name = {0}", Name);
            }

            //Static members

            public static string greetings = "Good Morning!";
            public static int Age { get; set; }
            public static void DisplayAge()
            {
                Console.WriteLine("Age = {0}", Age);
            }

            

        }

        
            
        }
    }

