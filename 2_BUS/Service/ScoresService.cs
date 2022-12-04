using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.DomianModels;
using _1_DAL.Respositories;
using _2_BUS.ViewModels;

namespace _2_BUS.Service
{

    public class ScoresService
    {
        private StudentRespository _studentRespository;
        private GradeRespository _gradeRespository;

        public ScoresService()
        {
            _gradeRespository = new GradeRespository();
            _studentRespository = new StudentRespository();
        }

        public List<Scores> GetScores()
        {
            List<Scores> lstScores = new List<Scores>();
            //lstScores = _studentRespository.GetStudentsFromDb().Join(_gradeRespository.GetGradesFromDb(),
            //    student => student.Id, grade => grade.IdStudent,
            //    ((student, grade) => new Scores()
            //    {
            //        Student = student,
            //        Grade = grade
            //    })).OrderByDescending(c => c.Grade.AvgSores).ToList();

            lstScores = (from a in _studentRespository.GetStudentsFromDb()
                         join b in _gradeRespository.GetGradesFromDb() on a.Id equals b.IdStudent
                         select new Scores()
                         {
                             Student = a,
                             Grade = b
                         }).OrderByDescending(c=>c.Grade.AvgSores).ToList();

            return lstScores;

        }

        public string AddScoes(Scores scores)
        {
            var grade = scores.Grade;
            if (_gradeRespository.AddGrade(grade))
            {
                return "Thêm thành công";
            }

            return "Thêm thất bại";
        }

        public string EditScores(Scores scores)
        {
            var grade = scores.Grade;
            if (_gradeRespository.EditGrade(grade))
            {
                return "Sửa thành công";
            }

            return "Sửa thất bại";
        }

        public string DeleteScores(Scores scores)
        {
            var grade = scores.Grade;
            if (_gradeRespository.DeleteGrade(grade))
            {
                return "Xóa thành công";
            }

            return "Xóa thất bại";
        }

        public Scores GetScoresById(Guid id)
        {
            return GetScores().FirstOrDefault(c => c.Grade.Id == id);
        }

        public Scores GetScoresByMaSv(string maSv)
        {
            return GetScores().FirstOrDefault(c => c.Grade.MaSv.ToLower() == maSv.ToLower());
        }
    }
}
