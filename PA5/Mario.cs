namespace PA5
{
    public class Mario : Character
    {
        public Mario()
        {
            Name = "Mario";
            MaxAttackPower = new Random().Next(1, 101);
            Health = 100;
            MaxDefensePower = new Random().Next(1, 101);
            AttackType = new Mario_Attack();
        }
    }
}