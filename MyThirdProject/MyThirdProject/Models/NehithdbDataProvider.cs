
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThirdProject.Models
{
    internal class NehithdbDataProvider
    {
        nehithdbContext db = new nehithdbContext();
        public void AddTotalMarks(string marksScored)
        {
            TblStudentMark m = new TblStudentMark();
            m.STotalMarks = 390;
            db.TblStudentMarks.Add(m);
            db.SaveChanges();
        }

        public void UpdateEmployeeDepartment(long id, string deptName)
        {
            TblEmployee emp = db.TblEmployees.Where(x => x.EmpId == id).FirstOrDefault();

            if (emp != null)
            {
                emp.Dept = deptName;
                db.SaveChanges();
            }
        }

        public void DeleteStudent(long id)
        {
            TblStudentDetail std = db.TblStudentDetails.Where(x => x.SId == id).FirstOrDefault();
            if (std != null)
            {
                db.TblStudentDetails.Remove(std);
                db.SaveChanges();
            }
        }

        public TblStudentDetail GetStudentById(long id)
        {
            TblStudentDetail std = db.TblStudentDetails.Where(x => x.SId == id).FirstOrDefault();
            return std;
        }

        public List<TblStudentDetail> GetEmployeesByGender(string gender)
        {
            List<TblStudentDetail> listEmp = db.TblStudentDetails.Where(x => x.SGender == gender).ToList();
            return listEmp;
        }
    }
}





