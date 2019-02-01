using System.Collections;
using System;
using Lessons;
using Quiz;

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
            //Console.WriteLine("ሰላም ወንድወሰን መልካም ገና!");
            //MyHouseResults();
           //MyNumericExamples();
            //myStringExamples(); 
            //StatementSamples();
            //HouseSamples();
            //CellPhone();
            //DisplayGrade();
            // Numbers();
            //FruitSamples();
            //Lessons11Samples();
            //ModifierExamples();
            //Lessons12();
            //AbstractDemo();
            //DeconstructSamples();
            //FinalizerExample();
            //IndexerExample();
            //AnotherHouseExamples();
            //GenericSample();
            //CollectionExamples();
            //Trangle();
            //pyramid();
            LabResults(); 

        }

        static void LabResults()
        {
            LabResults ce = new LabResults();
            ce.LabResultsExamples();
        }

        static void pyramid()
        {
            pyramid ce = new pyramid();
            ce.pyramidExamples();         
            
        }


        static void Trangle()
        {
            Trangle ce = new Trangle();
            ce.TriangleExamples();
        }

        static void CollectionExamples()
        {
            CollectionExamples ce = new CollectionExamples();
            ce.MyArrayListExample();
            ce.MyListExample();

        }        

        static void GenericSample()
        {
            GenericList<int>myList = new GenericList<int>();
            myList.add(10);

            GenericList<string> mySecondList = new GenericList<string>();
            
            mySecondList.add("Happy");

            GenericList<TRex> myTRexList = new GenericList<TRex>();
            
            myTRexList.add(new TRex());

        }

         static void AnotherHouseExamples()
        {
            House myhouse = new House()
            {
            Roof = "Shingles",
            Window = "Double Pane",
            PaintDoor = "Red",
            Foundation = "Concrete",
            };
        
        Console.WriteLine("my Windows choice is {0}", myhouse.Window);
        
        }
        static void IndexerExample()
        {
            IndexerExample myIndexer = new IndexerExample(); 

            myIndexer[2]= 250;

            for (int i = 0; i < myIndexer.Length; i++)
            {
                Console.WriteLine("Value {0} = {1}", i, myIndexer[i]);
            }   
        }
 
        static void FinalizerExample()
        {
            string first = "Bob", last = "Steve";
            FinalizerExample myExample = new FinalizerExample(first, last);
            Console.WriteLine("FirstName = {0} SecondName = {1}", first, last);


        }

        static void DeconstructSamples()
        {
            string first = "Tom", last = "James";

            Lessons13 Lessons13 = new Lessons13("John", "Doe");
            Console.WriteLine("firstName = {0} lastName = {1}", first, last);

            Lessons13.Deconstruct(out first, out last);
            Console.WriteLine("first Name = {0} last Name = {1}", first, last);
        }

        static void AbstractDemo()
        {
            TRex trex = new TRex();
            Triceratops triceratops = new Triceratops();

            trex.EatFood();
            trex.Sick();
            trex.Teeth();
            trex.Move();

            triceratops.EatFood();
            triceratops.SkinType();
            triceratops.Teeth();
            triceratops.Dead();
            triceratops.Move();
        }

        static void Lessons12()
        {
            double temp = Utilities.CelsiusToFahrenheit("43.2");
            double temp2 = Utilities.FahrenheitToCelsius("109.76");
            Console.WriteLine(temp);
            Console.WriteLine(temp2);

        }

        static void ModifierExamples()
        {
            int test = 14;
            Lessons11 myLessons = new Lessons11();
            myLessons.RefSamples(ref test);
            Console.WriteLine(test);
            string first, second;
            myLessons.OutSample("John Doe", out first, out second);

            Console.WriteLine(first);
            Console.WriteLine(second);
        }

        static void Lessons11Samples()
        {
            Lessons11 Lessons = new Lessons11();
            Lessons.useParams(10, 3, 24, 36, 45, 120);

            Lessons.useParams();

            int[] intArray = { 2, 3, 4, 5, 6 };
            Lessons.useParams(intArray);

            Lessons.useParams2(1, "Happy", false, 34, 5F);

            Lessons.OptionalParams("Roger");
            Lessons.OptionalParams("Mathew", 19);
        }


        static void FruitSamples()
        {
            Apple myApple = new Apple();
            myApple.EatFruit();

            Fruit myFruit = new Fruit();
            myFruit.EatFruit();

            Orange myOrange = new Orange();
            myOrange.EatFruit();

            RanchStyle ranch = new RanchStyle("Stone", "Triple Pane", "Composite", "blue");
            ranch.OpenDoor();
            Console.WriteLine(ranch.Roof);
        }

        static void Numbers()
        {
            Numbers mynumbers = new Numbers();
            mynumbers.Numbers0();
            Console.WriteLine();
        }
            /*static void CellPhone()
            {
        //    CellPhone mycellphone = new CellPhone();
        //    mycellphone.AnswerCall();
        //    Console.WriteLine();
        //    string words = mycellphone.StringBuilderExample("Hello", " answer Call ", " End Call");
            } */

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
            //Console.WriteLine(myString);
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
        //BottLessonsg();

        }

        static void DisplayGrade()
        {

            DisplayGrade grade = new DisplayGrade();
            Console.WriteLine(grade.grade("A, G, E,"));


        }
        static void BottLessonsg()
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

            BookSample bookSample = new BookSample(4.99m, "Zombie Fall Out", "Mark Tufo");

            Console.WriteLine("The book " + bookSample.title + " by " + bookSample.author + " is $" + bookSample.price);

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