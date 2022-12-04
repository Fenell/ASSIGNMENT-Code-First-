using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.DomianModels
{
    public class Grade
    {
        [Key]
        public Guid Id { get; set; }
        public double? CSharp3 { get; set; }
        public double? SqlServer { get; set; }
        public double? Agile { get; set; }
        public string MaSv { get; set; }

        public double AvgSores
        {
            get
            {
                var avg = ((Agile ?? 0) + (CSharp3 ?? 0) + (SqlServer ?? 0)) / 3;
                return Math.Round(avg, 1);
            }

        }

        public Guid IdStudent { get; set; }
        [ForeignKey(nameof(IdStudent))]

        [InverseProperty(nameof(Student.Grades))]
        public virtual Student StudentNavigation { get; set; }
    }
}
