using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns_exam
{
    public abstract class Player
    {
        protected ISkill skill;
        protected PlayerStatus status;

        protected Player(ISkill skill, PlayerStatus status)
        {
            this.skill = skill;
            this.status = status;
        }

        public abstract void Display();
    }
}
