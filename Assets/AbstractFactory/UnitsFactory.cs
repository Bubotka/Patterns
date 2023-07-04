namespace AbstractFactory
{
    public abstract class UnitsFactory
    {
        public abstract Mage CreateMage();
        public abstract Knight CreateKnight();
        public abstract Archer CreateArcher();
    }
}