using System;
namespace AbstractFactory
{
    using System.Collections.Generic;
    public class Blackhole
    {
        IAbstractFactory factory;
        List<IEnemy> enemies;
        

        public Blackhole(IAbstractFactory factory)
        {
            this.factory = factory;
            enemies = new List<IEnemy>();
        }

        public void CreateBlackhole()
        {
            
            enemies.Add(factory.CreateLegion());
            Console.WriteLine("Created Legion");
            enemies.Add(factory.CreateOrcs());
            Console.WriteLine("Created Orcs");
        }
    }
}
