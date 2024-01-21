using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns_exam
{
    public class MagicSkill : ISkill
    {
        public bool zeroBreaker { get ; set ; }

        public void PerformSkill()
        {
            Console.WriteLine("Choose a Spell:\n1) Fire Bolt\n2) Fire Arrow\n0) Exist");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x) 
            {
                case 0:
                    zeroBreaker = true;
                    break;
                case 1:
                    Console.WriteLine("You cast a Fire Bolt");
                    break;
                case 2:
                    Console.WriteLine("You cast a Fire Arrow");
                    break;
            }
        }
    }
}
