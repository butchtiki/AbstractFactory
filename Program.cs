using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyFactory enemyFactory = new EnemyFactory();
            Blackhole blackhole = new Blackhole(enemyFactory);
            blackhole.CreateBlackhole();
        }
    }
}
