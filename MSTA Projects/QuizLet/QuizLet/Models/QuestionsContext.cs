using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizLet.Models
{
    public class QuestionsContext
    {
        public List<Question> Questions { get; set; }
        public QuestionsContext()
        {
            Questions = MakeQuestions();
        }
        private List<Question> MakeQuestions()
        {
            Questions = new List<Question>();

            Question question1 = new Question();
            question1.Id = 0;
            question1.QuestionText = "What color is snow?";
            question1.Answers[0] = "Red";
            question1.Answers[1] = "Yellow";
            question1.Answers[2] = "White";
            question1.Answers[3] = "Green";
            question1.CorrectAnswer = 2;
            Questions.Add(question1);

            Question question2 = new Question(); 
            question2.Id = 1;
            question2.QuestionText = "What color is red?";
            question2.Answers[0] = "Red";
            question2.Answers[1] = "Yellow";
            question2.Answers[2] = "White";
            question2.Answers[3] = "Green";
            question2.CorrectAnswer = 0;
            Questions.Add(question2);

            return Questions;
        }
    }
}
