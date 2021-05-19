namespace AbstractFactory
{
    public interface IAbstractFactory
    {
        IEnemy CreateLegion();
        IEnemy CreateOrcs();
    }
}