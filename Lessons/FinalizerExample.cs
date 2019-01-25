using System;
namespace Lessons
{
    public class FinalizerExample
    {       public string FirstName { get; set; }
            public string SecondName { get; set; }

        public FinalizerExample(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }            

            ~FinalizerExample()
        {
            Console.WriteLine("Finalizer Called");            
        }
    }
}