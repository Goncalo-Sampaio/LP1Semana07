namespace GameUnits
{
    public class MilitaryUnit : XPUnit // Heranca!!
    {
        public int AttackPower { get; }
        public override int Health { get => base.Health + XP;
            set => base.Health = value; }

        public override float Cost { get => AttackPower + XP;}

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
        }

        public void Attack(Unit u){
            XP++;
            u.Health -= AttackPower;
        }

        public override string ToString(){
            return base.ToString() + $" AP={AttackPower}";
        }
    }
}
