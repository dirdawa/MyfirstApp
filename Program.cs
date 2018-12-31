using System;

/*This namespace represents the file folder that
the class is in. */
namespace classwork
{
    // Class is a blueprint of an object.
    class Program
    {
        /*static is only one, void is a return type
        Main is the method name, string[] is an array and a parameter */
        static void Main(string[] args)
        {
            // Console is a class, WriteLine is a method with a parameter
            Console.WriteLine("Hello World!");

            // Created and objacket instance of House called myHouse
            House myHouse = new House();
            // This sets the value of Red to the objects
            myHouse.PaintDoor = "Red";
            myHouse.CloseDoor();
            // This gets the value of Red from the object
            Console.WriteLine(myHouse.PaintDoor); // red
            // This is a second object instance of House.
            House mySecondHouse = new House();
            mySecondHouse.PaintDoor = "green";
            Console.WriteLine(mySecondHouse.PaintDoor); //green
            Console.WriteLine(myHouse.PaintDoor); //red
        }
    }
}