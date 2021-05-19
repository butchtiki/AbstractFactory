namespace AbstractFactory
{
    public interface IEnemy
    {
        void Move(int distance);
        void Attack(IEnemy enemy);
        void ReduceLife(int amount);
    }
}