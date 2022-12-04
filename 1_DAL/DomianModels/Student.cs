using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.DomianModels
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(8)]
        public string MaSv { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Sex { get; set; }
        public string Address { get; set; }
        public byte[]? Picture { get; set; }

        [InverseProperty(nameof(Grade.StudentNavigation))]
        public virtual ICollection<Grade> Grades { get; set; }
    }
}
