using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessClassLibrary.Models
{
    public class Question
    {
        public int ID { get; set; }

        public string Text { get; set; }

        public List<Answer> Answers { get; set; }

        public string Category { get; set; }

        public string Difficulty { get; set; }
    }
}
