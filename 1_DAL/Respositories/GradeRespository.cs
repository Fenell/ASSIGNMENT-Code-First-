using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Context;
using _1_DAL.DomianModels;

namespace _1_DAL.Respositories
{
    public class GradeRespository
    {
        private readonly DaoTaoContext _daoTaoContext;

        public GradeRespository()
        {
            _daoTaoContext = new DaoTaoContext();
        }

        public bool AddGrade(Grade obj)
        {
            try
            {
                obj.Id = Guid.NewGuid();
                _daoTaoContext.Grades.Add(obj);
                _daoTaoContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteGrade(Grade obj)
        {
            try
            {
                var grade = _daoTaoContext.Grades.FirstOrDefault(c => c.Id == obj.Id);
                _daoTaoContext.Remove(grade);
                _daoTaoContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditGrade(Grade obj)
        {
            try
            {
                var grade = _daoTaoContext.Grades.FirstOrDefault(c => c.Id == obj.Id);
                grade.CSharp3 = obj.CSharp3;
                grade.SqlServer = obj.SqlServer;
                grade.Agile = obj.Agile;
                grade.IdStudent = obj.IdStudent;
                grade.MaSv = obj.MaSv;
                _daoTaoContext.Update(grade);
                _daoTaoContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Grade> GetGradesFromDb()
        {
            return _daoTaoContext.Grades.ToList();
        }


    }
}
