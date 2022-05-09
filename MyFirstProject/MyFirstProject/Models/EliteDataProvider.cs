using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Models
{
    internal class EliteDataProvider
    {
        EliteContext db = new EliteContext();
        public void AddCourse(string courseName)
        {
            Course c = new Course();
            c.CourseName = "Ph.D";
            db.Courses.Add(c);
            db.SaveChanges();
        }

        public void UpdateEmployeePermanentAddress(long id, string permAddress)
        {
            Employee emp = db.Employees.Where(x => x.EmpId== id).FirstOrDefault();

            if (emp != null)
            {
                emp.PermanentAddress = permAddress;
                db.SaveChanges();
            }
        }

        public void DeleteEmployee(long id)
        {
            Employee emp = db.Employees.Where(x => x.EmpId == id).FirstOrDefault();
            if (emp != null)
            {
                db.Employees.Remove(emp);
                db.SaveChanges();
            }
        }

        public Employee GetEmployeeById(long id)
        {
            Employee emp = db.Employees.Where(x => x.EmpId == id).FirstOrDefault();
            return emp;
        }

        public List<Employee> GetEmployeesByGender(string gender)
        {
            List<Employee> listEmp = db.Employees.Where(x => x.Gender == gender).ToList();
            return listEmp;
        }
    }
}
