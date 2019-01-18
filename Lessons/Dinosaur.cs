using System;
namespace Lessons
{
    public abstract class Dinosaur
    {
        public abstract void EatFood();
        public virtual void Move()
        {
            Console.WriteLine("The Dinosaur Moves"); 
        }
        
        public abstract void Sick();
        public virtual void Dead()
        {
            Console.WriteLine("The Dinosaur Sick");          

        }
    }
}