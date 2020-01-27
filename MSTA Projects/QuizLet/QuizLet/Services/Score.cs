using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizLet.Services
{
    public class Score : IScore
    {
        public int Correct { get; set; }
        public int Wrong { get; set; }

        void IScore.Score(bool result)
        {
            if (result == true)
            {
                Correct++;
            }
            else
            {
                Wrong++;
            }
        }
    }
}
