using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns_exam
{
    public interface ISkill
    {
        public bool zeroBreaker { get; set; }

        void PerformSkill();
    }
}
