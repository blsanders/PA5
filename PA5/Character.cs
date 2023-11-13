namespace PA5
{
    public class Character
    {
        public string? Name { get; set; }
        public int MaxAttackPower { get; set; }
        public int Health { get; set; }
        public int MaxDefensePower { get; set; }
        public IAttack AttackType { get; set; }
    }
}