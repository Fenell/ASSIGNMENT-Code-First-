using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.DomianModels;
using _1_DAL.Respositories;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace _2_BUS.Service
{
    public class StudentService
    {
        private StudentRespository _studentRespository;
        public StudentService()
        {
            _studentRespository = new StudentRespository();
        }

        public List<Student> GetAllStudents()
        {
            return _studentRespository.GetStudentsFromDb().OrderBy(c => c.MaSv).ToList();
        }

        public string AddStudent(Student student)
        {
            if (_studentRespository.AddStudent(student))
            {
                return "Thêm thành công";
            }

            return "Thêm thất bại";
        }

        public string DeleteStudent(Student student)
        {
            if (_studentRespository.DeleteStudent(student))
            {
                return "Xóa thành công";
            }

            return "Xóa thất bại";
        }

        public string EditStudent(Student student)
        {
            if (_studentRespository.EditStudent(student))
            {
                return "Sửa thành công";
            }

            return "Sửa thất bại";
        }

        public Student GetStudentById(Guid id)
        {
            return _studentRespository.GetStudentsFromDb().FirstOrDefault(c => c.Id == id);
        }

        public Student GetStudentByMaSv(string maSv)
        {
            var student = _studentRespository.GetStudentsFromDb().FirstOrDefault(c => c.MaSv.ToLower() == maSv.ToLower());

            return student;
        }

        public string AutoGenerateMaSv()
        {
            int genMaSv;
            string maSv;
            int countLstStudent = _studentRespository.GetStudentsFromDb().Count;

            for (genMaSv = 1; genMaSv <= countLstStudent; genMaSv++)
            {
                maSv = $"PH{genMaSv.ToString().PadLeft(6, '0')}";
                if (!_studentRespository.GetStudentsFromDb().Any(c => c.MaSv == maSv))
                {
                    return maSv;
                }
            }
            genMaSv = countLstStudent + 1;
            maSv = $"PH{genMaSv.ToString().PadLeft(6, '0')}";

            return maSv;
        }

        public bool HasStudent(Guid id)
        {
            return _studentRespository.GetStudentsFromDb().Any(C => C.Id == id);
        }

        public bool HasStudentByMaSv(string maSv)
        {
            if (string.IsNullOrEmpty(maSv))
            {
                return false;
            }
            return _studentRespository.GetStudentsFromDb().Any(c => c.MaSv == maSv);
        }

        public List<string> GetMaSvtoList()
        {
            return _studentRespository.GetStudentsFromDb().Select(c => c.MaSv).ToList();
        }
    }
}
