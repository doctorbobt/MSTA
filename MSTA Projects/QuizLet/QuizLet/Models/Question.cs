using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizLet.Models
{
    public class Question
    {
        public Question()
        {
            Answers = new string[4];
        }
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswer { get; set; }
    }
}
