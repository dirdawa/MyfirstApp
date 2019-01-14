using System;
namespace Lessons
{
    public class Fruit
    {        	
        public virtual void EatFruit()
        {
	    Console.WriteLine("I eat fruit");
        ThrowFruit();
        }

        
        // private is only accessible from  within the class
        private void ThrowFruit()
        {
        Console.WriteLine("Throw Fruit");
        }
    }
       
}