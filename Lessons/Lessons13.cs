using System;
namespace Lessons
{
    public class Lessons13
   {
        string _firstName, _lastName;

        public Lessons13(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }
        
        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = this._firstName;
            lastName = this._lastName;
            Console.WriteLine("Deconstruct Called");
        }

    }
}


