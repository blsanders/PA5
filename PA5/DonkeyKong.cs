namespace PA5
{
    public class DonkeyKong : Character
    {
        public DonkeyKong()
        {
            Name = "Donkey Kong";
            MaxAttackPower = new Random().Next(1, 101);
            Health = 100;
            MaxDefensePower = new Random().Next(1, 101);
            AttackType = new DonkeyKong_Attack();
        }
    }
}