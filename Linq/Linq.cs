using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq1
{
    public class Program1
    {
        public static int[] numberList = {1,2,3,4};
        public static int sum = 0;

         // method demonstrating the sum of squares using Linq           
        public static int sumOfSquares()
        {
            return numberList.Sum(num => num * num);
        }
    
        public static void Main()
        {
           

            sum = sumOfSquares();
            System.Console.WriteLine("The sum of squares is: {0}",sum);


            // code demonstrating the filtering of a list using Linq

            List<Student> students = new List<Student>();
            
            students.Add(new Student("Chris", "123-456-7891", "123 Delany", -2990));
            students.Add(new Student("Kevin", "512-222-2222", "435 Carolyn", -2500));
            students.Add(new Student("Victoria", "512-827-8498", "701 Brazos St", 0));
            students.Add(new Student("Luke", "555-555-5555", "451 Brody Ln", -500));
            
            
            var negbalStudents = 
                from st in students
                where (st.Balance < 0)
                select st;

                System.Console.WriteLine("The students with negative balances are: ");
                foreach (Student st in negbalStudents)
                {
                    System.Console.WriteLine(st.Name);
                }
        }
    }
    
    public class Student
	{
		public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
		public int Balance { get; set; }
		
		public Student (string name, string phone, string address, int balance)
		{
			Name = name;
			Phone = phone;
			Address = address;
			Balance = balance;
		}
	}
}

