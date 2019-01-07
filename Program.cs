using System;
using Lessons;

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
            //  Console.WriteLine("Hello World!");
            // MyHouseResults();
            // MyNumericExamples();
            // myStringExamples(); 
            StatementSamples();

        }
           static void StatementSamples()
        {
           StatementExamples se = new StatementExamples();
           se.SampleIf();
           se.SampleIfElse();
           se.SampleIfChain();
           se.SampleIfAnd();
           se.SampleIfOr();
           se.SampleConditional();
           se.SampleSwitch(10);
           se.SampleWhile();
           se.SampleDoWhile();

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