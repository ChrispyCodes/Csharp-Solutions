using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadOperator
{
    class Employee
    {
       
            public int Employee01 { get; set; }
            public int Employee02 { get; set; }
            public int Id { get; set; }

           
            public static bool operator == (Employee Employee01, Employee Employee02)
            {
                if (Employee01.Id == Employee02.Id)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        public static bool operator != (Employee Employee01, Employee Employee02)
        {
            if (Employee01.Id != Employee02.Id)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object emp)
            {
            return base.Equals(emp);
            
        }
    }
}