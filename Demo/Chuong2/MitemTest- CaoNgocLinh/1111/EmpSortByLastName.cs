using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111
{
    class EmpSortByLastName: IComparer<Employee>
        {
           
            public int Compare(Employee x, Employee y)
            {
                Employee itemEmp1 = x ;
                Employee itemEmp2 = y ;
                if (itemEmp1 != null && itemEmp2 != null)
                {
                    return itemEmp1._lastName.CompareTo(itemEmp2._lastName);
                }
                else
                    throw new ArgumentException();
            }
        }
}
