using System;

namespace GameUnits
{
    public class Program
    {
        private static void Main()
        {
            // Criar array com três unidades
            Unit[] units = new Unit[]
            {
                new MilitaryUnit(3, 10, 3),
                new MilitaryUnit(4, 5, 1),
                new SettlerUnit(),
                new DiplomatUnit(),
                new DiplomatUnit()
            };

            foreach (Unit u in units)
            {
                Console.WriteLine(u);
            }
            
            Console.WriteLine();

            // Unidade 0 ataca unidade 1
            (units[0] as MilitaryUnit).Attack(units[1]);
            // Unidade 1 ataca unidade 2
            (units[1] as MilitaryUnit).Attack(units[2]);
            // Unidade 3 faz acordo comercial com unidade 4
            (units[3] as DiplomatUnit).MakeAgreement(units[4]);
            // Unidade 4 faz acordo comercial com unidade 2
            (units[4] as DiplomatUnit).MakeAgreement(units[2]);

            // "Imprimir" cada unidade
            // chamando implicitamente o método ToString() de cada uma delas
            foreach (Unit u in units)
            {
                Console.WriteLine(u);
            }

            // Output esperado:
            //
            // MilitaryUnit: HP=11 COST=4.00 XP=1 AP=3
            // MilitaryUnit: HP=3 COST=2.00 XP=1 AP=1
            // SettlerUnit: HP=2 COST=5.00
            // DiplomatUnit: HP=1 COST=7.10 XP=3
            // DiplomatUnit: HP=1 COST=7.10 XP=2
        }
    }
}
