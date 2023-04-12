using System;
using System.Collections.Generic;

/*
   Client Class or Dependant Object
   This is the class that is going to consume the services provided by the EmployeeDAL.cs class
   That means it is the dependent class which is depending on the EmployeeDAL.cs class
*/

namespace Understanding_DI
{
    public class EmployeeBL
    {
        private  IEmployeeDAL _employeeDAL;
        public EmployeeBL(IEmployeeDAL employeeDAL)
        {
            this._employeeDAL = employeeDAL;
            
        }
      
        public List<Employee> ReadAllEmployee()
        {
            return _employeeDAL.GetAllEmployees();            
        }
    }
}