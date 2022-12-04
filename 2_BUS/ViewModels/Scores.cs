using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.DomianModels;

namespace _2_BUS.ViewModels
{
    public class Scores
    {
        public Student Student { get; set; }
        public Grade Grade { get; set; }
    }
}
