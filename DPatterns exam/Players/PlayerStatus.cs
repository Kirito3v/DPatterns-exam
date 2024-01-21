using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns_exam
{
    public class PlayerStatus
    {
        public int HP = 300;
        public int MP = 150;
        public int Str = 10;
        public int Dex = 8;
        public int Stamina = 100;

        private static PlayerStatus playerStatus;

        private PlayerStatus()
        {
            
        }

        public static PlayerStatus status 
        {
            get 
            {
                if (playerStatus is null) 
                {
                    playerStatus = new PlayerStatus();
                }
                return playerStatus;
            }
        }

        public void IncreaseMP(int amount)
        {
            MP += amount;
        }

        public void IncreaseStr(int amount)
        {
            Str += amount;
        }
    }
}
