using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns_exam
{
    class SwordSkill : ISkill
    {
        public bool zeroBreaker { get; set; }

        public void PerformSkill()
        {
            Console.WriteLine("Choose a Skill:\n1) Slash\n2) Swing\n0) Exist");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 0:
                    zeroBreaker = true;
                    break;
                case 1:
                    Console.WriteLine("You use your Sword to Slash");
                    break;
                case 2:
                    Console.WriteLine("You use your Sword to Swing");
                    break;
            }
        }
    }
}
