using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblems1
{
    public  class CompanyEmpWage
	{
		public string company;
		public int empRatePerHour;
		public int numOfWorkingDays;
		public int maxHoursPerMonth;
		public int totalEmpWage;
		public int dailyWage;
		public int TotalWageAlongWithDailyWage;
		public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth) //parameterized constructer
		{
			//invoke current class constructor
			this.company = company;
			this.empRatePerHour = empRatePerHour;
			this.numOfWorkingDays = numOfWorkingDays;
			this.maxHoursPerMonth = maxHoursPerMonth;
		}

		public void setTotalEmpWage(int totalEmpWage) //set method
		{
			this.totalEmpWage = totalEmpWage;
		}

		public string toString() //instance method 
		{

			return "\n Total Emp Wage for Company : " + this.company + " is :" + this.totalEmpWage + "\n Daily Wage for Company : " + this.company + " is :" + this.dailyWage + "\n Total  Emp wage along with daily Wage is " + this.TotalWageAlongWithDailyWage;
		}
	}
}