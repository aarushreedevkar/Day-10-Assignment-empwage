﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblems1
{
    public class EmpWageBuilderArray
    {
		public const int IS_PART_TIME = 1;
		public const int IS_FULL_TIME = 2;

		private int numOfCompany = 0;
		private CompanyEmpWage[] companyEmpWageArray;

		public EmpWageBuilderArray()
		{
			this.companyEmpWageArray = new CompanyEmpWage[5];
		}

		public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth)
		{
			companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHourPerMonth);
			numOfCompany++;
		}

		public int computeEmpWage(CompanyEmpWage companyEmpWage)
		{
			int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
			while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
			{
				totalWorkingDays++;
				Random random = new Random();
				int empCheck = random.Next(0, 3);
				switch (empCheck)
				{
					case IS_PART_TIME:
						empHrs = 4;
						break;
					case IS_FULL_TIME:
						empHrs = 8;
						break;
					default:
						empHrs = 0;
						break;
				}
				totalEmpHrs += empHrs;
				Console.WriteLine("Days" + totalWorkingDays + "EmpHrs : " + empHrs);
			}
			return totalEmpHrs * companyEmpWage.empRatePerHour;
		}
	}
}
    

