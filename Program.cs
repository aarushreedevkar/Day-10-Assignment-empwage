namespace EmployeeWageProblems1
{
    class Program
    {
      //  ***************Welcome to the Employee Wage computation Program**************//
        public static void Main(string[] args)
        {
			Console.WriteLine("welcome to employee Program");
			EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();  //creat object of EmpWageBuilderArray class
			empWageBuilder.AddCompanyEmpWage("DMart", 20, 2, 10); //call AddCompany method
			empWageBuilder.AddCompanyEmpWage("Reliance", 10, 4, 20);
			empWageBuilder.computeEmpWage();

			Console.Read();
		}


	}
}

	

		


	




	


