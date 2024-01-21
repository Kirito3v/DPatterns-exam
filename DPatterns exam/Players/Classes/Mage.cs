using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns_exam
{
    public class Mage : Player
    {
        public Mage(ISkill skill, PlayerStatus status) : base(skill, PlayerStatus.status)
        {
            status.IncreaseMP(100);
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Mage");
            while (status.MP > 0) 
            {
                skill.PerformSkill();
                if (skill.zeroBreaker)
                    return;
                status.MP -= 5;
                Console.WriteLine(status.MP);
            }
            if (status.MP <= 0)
                Console.WriteLine("Out of Mana");
        }
    }
}
