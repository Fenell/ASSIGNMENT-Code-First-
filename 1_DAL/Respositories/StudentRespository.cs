using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Context;
using _1_DAL.DomianModels;

namespace _1_DAL.Respositories
{
    public class StudentRespository
    {
        private DaoTaoContext _daoTaoContext;
        public StudentRespository()
        {
            _daoTaoContext = new DaoTaoContext();
        }

        public List<Student> GetStudentsFromDb()
        {
            return _daoTaoContext.Students.ToList();
        }

        public bool AddStudent(Student obj)
        {
            try
            {
                obj.Id = Guid.NewGuid();
                _daoTaoContext.Add(obj);
                _daoTaoContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteStudent(Student obj)
        {
            try
            {
                var student = _daoTaoContext.Students.FirstOrDefault(c => c.Id == obj.Id);
                _daoTaoContext.Remove(student);
                _daoTaoContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditStudent(Student obj)
        {
            try
            {
                var student = _daoTaoContext.Students.FirstOrDefault(c => c.Id == obj.Id);
                student.MaSv = obj.MaSv;
                student.Name = obj.Name;
                student.Email = obj.Email;
                student.Phone = obj.Phone;
                student.Sex = obj.Sex;
                student.Picture = obj.Picture;
                _daoTaoContext.Update(student);
                _daoTaoContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
