
using System; 
namespace Lessons
{
    public class Triceratops : Dinosaur
    {
        public override void EatFood()
        {
            Console.WriteLine("Triceratops eats");
        }

        public override void Sick()
        {
            Console.WriteLine("Triceratops Is Sick");
            Console.WriteLine("Triceratops Is Dead");
        }
    }
}
