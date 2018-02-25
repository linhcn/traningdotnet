using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111
{
    class EmpSortByMonthSalary: IComparer<Employee>
    {
   
        public int Compare(Employee x, Employee y)
        {
            Employee itemEmp1 = x ;
            Employee itemEmp2 = y ;
            if (itemEmp1 != null && itemEmp2 != null)
            {
                if (itemEmp1.getMonthlySalary().CompareTo(itemEmp2.getMonthlySalary()) == -1)
                {
                    return 1;
                }
                if (itemEmp1.getMonthlySalary().CompareTo(itemEmp2.getMonthlySalary()) == 1)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
                throw new ArgumentException();
        }
    }
}
