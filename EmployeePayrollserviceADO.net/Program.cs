﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollserviceADO.net
{
   class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository empRepo = new EmployeeRepository();
            empRepo.DataBaseConnection();
            Console.ReadLine();
        }
    }
}
