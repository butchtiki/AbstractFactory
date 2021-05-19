using System;
namespace AbstractFactory
{
    public class Orc : IEnemy
    {
        int life;
        int attackDamage { get; set; }
        int position;
        
        public Orc()
        {
            position = 0;
            attackDamage = 10;
            life = 100;
        }

        public void Attack(IEnemy enemy)
        {
            enemy.ReduceLife(attackDamage);
        }

        public void Move(int distance)
        {
            this.position += distance;
        }

        public void ReduceLife(int amount)
        {
            this.life -= amount; 
        }

        public int GetAttackDamage()
        {
            return attackDamage;
        }
    }
}
