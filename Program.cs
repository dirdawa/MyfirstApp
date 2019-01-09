using System;
using Lessons;

/*This namespace represents the file folder that
the class is in. */
namespace classwork
{
    //Class is a blueprint of an object.
    class Program
    {
        /*static is only one, void is a return type
        Main is the method name, string[] is an array and a parameter */
        static void Main(string[] args)
        {
             //Console is a class, WriteLine is a method with a parameter
             //Console.WriteLine("Hello World!");
            // Console.WriteLine("ሰላም ወንድወሰን መልካም ገና!");
             //MyHouseResults();
             //MyNumericExamples();
             //myStringExamples(); 
             //StatementSamples();
             HouseSamples();
                        
        }
        static void JumpStatementExamples()
        {
        
        }
        static void SimpleCalculator()
        {

        }
        static void StatementExamples()
        {

        }
        static void StatementSamples()
        {
            StatementExamples se = new StatementExamples();
            //se.SampleIf();
            //se.SampleIfElse();
            //se.SampleIfChain();
            //se.SampleIfAnd();
            //se.SampleIfOr();
            //se.SampleConditional();
            //se.SampleSwitch(10);
            //se.SampleWhile();
            //se.SampleDoWhile();
            //se.SampleForEach();
            //string myString = se.JumpStatementExample("Sunday");
           // Console.WriteLine(myString);
            //se.SampleDays(DaysOfWeek.Wed);
        }
        static void MyNumericExamples()
        {


            NumericTypes myTypes = new NumericTypes();
            myTypes.GetSomeType();

            int something = myTypes.ConvertFloatToInt(35.9F);
            Console.WriteLine(something);

            Console.WriteLine(myTypes.LongFromInt(5600));
            myTypes.BasicMath();

            //myTypes.CheckOperators();
            //myTypes.IncrementDecremenet();
            //myTypes.SpcialValues();
            //myTypes.ComparisonOperators();
            //myTypes.OtherOprators();
            //myTypes.OtherNumericExamples();
            //BottlesSong();
            // SimpleCalculator();
            
        }

        static void BottlesSong()
        {
            BottlesofBeer beer = new BottlesofBeer();
            string song = beer.BottlesofBeerSong();
            Console.WriteLine(song);
        }
        static void myStringExamples()

        {
            stringtypes myTypes = new stringtypes();
            myTypes.SamplesString();
            myTypes.AddString();
            string words = myTypes.StringBuilderExample("Hello", "C Sharp", "Class");

            Console.WriteLine(words);
            myTypes.CharTypExamples();
            myTypes.EscapeExample();
            myTypes.PlaceHolderExample();
            myTypes.ArraySample();
            myTypes.MyHouseArray();
            myTypes.MultiArraySample();
            
        }

        static void HouseSamples()
        {
            House myHouse = new House("concrete", "triple Pane");

            Console.WriteLine(myHouse.PaintDoor);
            Console.WriteLine(myHouse.Foundation);

            myHouse.OpenDoor(true);

            BookSample bookSample = new BookSample(4.99m,"Zombie Fall Out", "Mark Tufo");

            Console.WriteLine ("The book " + bookSample.title + " by " + bookSample.author + " is $" + bookSample.price);

        }

        static void OtherNumericExamples()

        {

        }
        static void MyHouseResults()
        {
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