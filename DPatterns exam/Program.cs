namespace DPatterns_exam
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Clear();
                Console.WriteLine("Choose Your Destiny lil Human\n1) Warrior\n2) Mage");
                int x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        Player warrior = new Warrior(new SwordSkill(), PlayerStatus.status);
                        warrior.Display();
                        break;
                    case 2:
                        Player mage = new Mage(new MagicSkill(), PlayerStatus.status);
                        mage.Display();
                        break;
                }

                Console.WriteLine("\nPress R to restart");
                while (Console.ReadKey().Key is not ConsoleKey.R) 
                {
                    Console.WriteLine("\nPress R dude");
                }
            }
        }
    }
}