using System;
using System.Collections.Generic;


namespace Understanding_DI
{
    public class EmployeeDAL
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>
            {
               /* The list of employees can be read from the Db - 
                  But for simplicty, we hardcode the employee data */
                  new Employee() { ID = 1, Name = "Felly KANYIKI", Department = "Engineering"},
                  new Employee() { ID = 2, Name = "Fanny KANYIKI", Department = "Finance"},
                  new Employee() { ID = 3, Name = "Jovial KANYIKI", Department = "Medical"},
                  new Employee() { ID = 4, Name = "Rosette KANYIKI", Department = "Legal"},
            };
            return ListEmployees;
        }
    }
}