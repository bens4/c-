using System;

namespace Salary
{
    class Employee
    {
        public string employe_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public char gender { get; set; }
        public string position { get; set; }
        public string employe_category { get; set; }
        public double gross_salary { get; set; }
        public double N_salary { get; set; }

        public Employee()
        {
            Console.WriteLine("Employee ID: ");
            this.employe_id = Console.ReadLine();
            Console.WriteLine("First Name: ");
            this.first_name = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            this.last_name = Console.ReadLine();
            Console.WriteLine("Gender: ");
            this.gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Position: ");
            this.position = Console.ReadLine();
            Console.WriteLine("Employee Category: Monthly|Hourly|One-Time");
            this.employe_category = Console.ReadLine();
            Console.WriteLine("Employee Gross Salary: ");
            this.gross_salary = Convert.ToDouble(Console.ReadLine());
        }

        public Employee(string employe_id, string first_name, string last_name, char gender, string position, string employe_category,
            double gross_salary, double N_salary)
        {
            this.employe_id = employe_id;
            this.first_name = first_name;
            this.gender = gender;
            this.position = position;
            this.employe_category = employe_category;
            this.gross_salary = gross_salary;
            this.N_salary = N_salary;
        }

        public string empInfo()
        {
            return string.Format(
                "Employere ID: {0} \nFirst Name: {1} \nLast Name: {2} \nGender: {3} \nEmployee Position: {4} \nEmployee Category: {5} \nEmployee Gross Salary: {6} \n",
                employe_id, first_name, last_name, gender, position, employe_category, gross_salary);
        }

        public double netSalary()
        {
            double tax, rssb, insurance, rate;
            if (employe_category == "Monthly")
            {
                tax = (30 * gross_salary) / 100;
                rssb = (5 * gross_salary) / 100;
                insurance = (3 * gross_salary) / 100;
                N_salary = gross_salary- (tax + rssb + insurance);
            }
            else if (employe_category == "Hourly")
            {
                double hrs;
                Console.WriteLine("Number of Hours Worked: ");
                hrs= Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Rate Per Hour: ");
                rate = Convert.ToDouble(Console.ReadLine());
                rssb = (5 * gross_salary) / 100;
                insurance = (3 * gross_salary) / 100;
                N_salary = (hrs * rate) - (rssb + insurance);
            }
            else if (employe_category == "One-Time")
            {
                tax = (30 * gross_salary) / 100;
                N_salary = gross_salary - tax;
            }
            return N_salary;
        }
        static void Main(string[] args)
        {
            Employee emp01 = new Employee();
            Console.WriteLine("Review Information: Y|N ");
            string check = Console.ReadLine();
            if (check == "Y")
            {
                Console.WriteLine(emp01.empInfo());
            }
            else
            {
                Console.WriteLine("OKAY");
            }
            Console.WriteLine("Calculate Net Salary: Y|N ");
            check = Console.ReadLine();
            if (check == "Y")
            {
                Console.WriteLine("Net Salary: "+emp01.netSalary());
            }
            else
            {
                Console.WriteLine("That's All");
            }
        }
    }
}