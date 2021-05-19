using System;
namespace AbstractFactory
{
    public class EnemyFactory : IAbstractFactory
    {
        public EnemyFactory()
        {
        }

        public IEnemy CreateLegion()
        {
            return new Legion();
        }

        public IEnemy CreateOrcs()
        {
            return new Orc();
        }
    }
}
