namespace EmployeeWageProblems1
{
    class Program
    {
      //  ***************Welcome to the Employee Wage computation Program**************//
        public static void Main(string[] args)
        {
            EmployeePresentAbsent employeePresentAbsent = new EmployeePresentAbsent();
            employeePresentAbsent.EmployeePresentOrAbsent();

            DailyEmployeeWages dailyEmpwage = new DailyEmployeeWages();
            dailyEmpwage.EmployeeDailyWage();

            PartTimeEmployeeWages partTimeEmployeeWage = new PartTimeEmployeeWages();
            partTimeEmployeeWage.PartTimeWage();

            CalculateWages calculateWages = new CalculateWages();
            calculateWages.calculateHrswages();

            SwitchCaseStatement switchCaseStatement = new SwitchCaseStatement();
            switchCaseStatement.CaseStatement();

            MonthlyEmpWages monthlyEmpWage = new MonthlyEmpWages();
            monthlyEmpWage.MontlyWageComputation();

            EmployeeWages employeeWage = new EmployeeWages();
            employeeWage.ComputeWages();

            MultipleCompanies multipleCompanies = new MultipleCompanies();
            multipleCompanies.ComputeWage();

        }


    }

}
    

