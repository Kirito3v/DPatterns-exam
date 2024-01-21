using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns_exam
{
    class Warrior : Player
    {
        public Warrior(ISkill skill, PlayerStatus status) : base(skill, status)
        {
            status.IncreaseStr(15);
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Warrior");

            while (status.Stamina > 0) 
            {
                skill.PerformSkill();
                if (skill.zeroBreaker)
                    return;
                status.Stamina -= 5;
                Console.WriteLine(status.Stamina);
            }
            if (status.Stamina <= 0)
                Console.WriteLine("Out of Stamina");
        }
    }
}
