using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            MilitaryUnit mU = new MilitaryUnit(1, 5, 2);
            SettlerUnit sU = new SettlerUnit();

            mU.Move(2);
            sU.Move(1);
            Console.WriteLine($"Military health: {mU.Health}, cost: {mU.Cost}");
            Console.WriteLine($"Settler health: {sU.Health}, cost: {sU.Cost}");
        }
    }
}
