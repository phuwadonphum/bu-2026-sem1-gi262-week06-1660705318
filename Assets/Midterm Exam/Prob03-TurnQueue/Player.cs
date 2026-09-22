namespace MidtermExam.Prob03
{
    public class Player
    {
        public string Name;
        public int Health;

        public Player(string name, int health = 100)
        {
            Name = name;
            Health = health;
        }

        public void Attack(Player target)
        {
            if (target != null) target.TakeDamage(10);
        }

        public void TakeDamage(int damage)
        {
            Health = System.Math.Max(0, Health - damage);
        }
    }
}

