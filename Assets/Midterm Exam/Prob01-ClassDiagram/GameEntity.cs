using UnityEngine;

namespace MidtermExam.Prob01
{
    public class GameEntity
    {
        public string id;
        protected Vector3 position;
        private int health;

        public virtual void Update()
        {
        }

        public virtual void TakeDamage(int damage)
        {
            health -= damage;
        }

        private void Move(Vector3 direction)
        {
            position += direction;
        }
    }
}
