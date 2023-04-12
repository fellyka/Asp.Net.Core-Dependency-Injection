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
        public EmployeeDAL employeeDAL = new EmployeeDAL();
        public List<Employee> ReadAllEmployee()
        {
            //Creating an Instance of Dependency class means it a TIGHT Coupling 
            // If in the EmployeeDAL.cs, the name of the method changes from 
            //GetAllEmployees to for example Get_AllEmployees, the codes will break
            //And the EmployeeBL.cs will need to be updated accordingly
            return employeeDAL.GetAllEmployees();            
        }
    }
}