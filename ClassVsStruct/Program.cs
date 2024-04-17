using System;

namespace ClassVsStruct
{
    public class Program
    {
        private static void Main()
        {
            PlayerClass pc = new PlayerClass() { Health = 100, Armour = 100};
            PlayerStruct ps = new PlayerStruct() { Health = 100, Armour = 100 };

            KillPlayerClass(pc);
            KillPlayerStruct(ps);

            Console.WriteLine($"Class : {pc.Health}");
            Console.WriteLine($"Struct: {ps.Health}");
        }

        private static void KillPlayerClass(PlayerClass pc)
        {
            pc.Health = 0;
        }

        private static void KillPlayerStruct(PlayerStruct ps)
        {
            ps.Health = 0;
        }
    }
}
