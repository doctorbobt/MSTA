using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizLet.Services
{
    public interface IScore
    {
        int Correct { get; set; }
        int Wrong { get; set; }
        void Score(bool result);
    }
}
