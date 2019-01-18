
using System;
namespace Lessons
{
    public class TRex : Dinosaur
    {
        public override void EatFood()
        {
            Console.WriteLine("TRex eats");
        }   

        public override void Move() 
        {
            Console.WriteLine("TRex runs");
        }
        
        public override void Sick()
        {
            Console.WriteLine("Dinosaur Sick");
        }

        public override void SkinType() 
        {
            Console.WriteLine("Feathery");
        }
            
        public override void Teeth()
        {
           Console.WriteLine("Razor Sharp");	 
        }
        
    }
}   