using System;
namespace AbstractFactory
{
    public class Legion : IEnemy
    {
        int life;
        int position;
        int attackDamage { get; set; }

        public Legion()
        {
            position = 0;
            life = 100;
            attackDamage = 16;
        }

        public void Attack(IEnemy enemy)
        {
            enemy.ReduceLife(attackDamage);
        }

        public void Move(int distance)
        {
            position += distance;
        }

        public void ReduceLife(int amount)
        {
            life -= amount;
        }

        public int GetAttackDamage()
        {
            return attackDamage;
        }
    }
}
