namespace PA5
{
    public class Bowser : Character
    {
        public Bowser()
        {
            Name = "Bowser";
            MaxAttackPower = new Random().Next(1, 101);
            Health = 100;
            MaxDefensePower = new Random().Next(1, 101);
            AttackType = new Bowser_Attack();
        }
    }
}