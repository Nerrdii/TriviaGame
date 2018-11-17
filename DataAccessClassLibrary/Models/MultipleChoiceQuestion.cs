using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessClassLibrary.Models
{
    public class MultipleChoiceQuestion
    {
        public int QuestionID { get; set; }

        public string Question { get; set; }

        public List<Answer> Answers { get; set; }

        public string Category { get; set; }

        public string Difficulty { get; set; }
    }
}
