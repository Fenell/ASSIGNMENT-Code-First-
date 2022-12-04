using _1_DAL.DomianModels;
using _1_DAL.Respositories;
using _2_BUS.ViewModels;

namespace _2_BUS.Service
{
    public class GradeService
    {
        private GradeRespository _gradeRespository;
        private StudentRespository _studentRespository;

        public GradeService()
        {
            _gradeRespository = new GradeRespository();
            _studentRespository = new StudentRespository();
            GetScores();
        }

        public List<Grade> GetScores()
        {
            return _gradeRespository.GetGradesFromDb().OrderByDescending(c => c.AvgSores).ToList();
        }

        public string AddGrade(Grade grade)
        {
            if (_gradeRespository.AddGrade(grade))
            {
                return "Thêm thành công";
            }

            return "Thêm thất bại";
        }

        public string DeleteGrade(Grade grade)
        {

            if (_gradeRespository.DeleteGrade(grade))
            {
                return "Xóa thành công";
            }

            return "Xóa thất bại";
        }

        public string EditGrade(Grade grade)
        {
            if (_gradeRespository.EditGrade(grade))
            {
                return "Sửa thành công";
            }

            return "Sửa thất bại";
        }

        public Grade GetGradebyMaSv(string mav)
        {
            return _gradeRespository.GetGradesFromDb().FirstOrDefault(c => c.MaSv.ToLower() == mav.ToLower());
        }

        public Grade GetGradesById(Guid id)
        {
            return _gradeRespository.GetGradesFromDb().FirstOrDefault(c => c.Id == id);
        }

        public bool HasScores(string maSv)
        {
            return _gradeRespository.GetGradesFromDb().Any(c => c.MaSv.ToLower() == maSv.ToLower());
        }
    }
}
