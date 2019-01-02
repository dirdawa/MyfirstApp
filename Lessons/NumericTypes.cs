using System;
namespace Lessons
{

    public class NumericTypes
    {
        /*Integral - Signed */
        // rang 128 - 127
        sbyte _mySbyteValue = 1;

        // rang -32,768 - 32,767
        short _myShortValue = 4;

        // rang -2,147,483,648 - 2,147,483,647
        int _myIntValue = 25000;

        // rang -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        long _myLongValue = 1234567L;
        long _myLongValue2 = 0x5F;

        /*Integeral - Unsigned */
        // rang 0 to 255
        byte _myByteValue = 3;

        // range 0 to 65,535
        ushort _myUShortValue = 35;

        // range 0 - 4,294,965,295 
        uint _myUIntValue = 2345U;

        // range 0 - 18,446,744,073,709,551,615
        ulong _myULongValue = 123456UL;

        /* Real Numbers */
        // range 3.4E +/- 38(7 digits)
        float _myFloatValue = -123.6589F;

        // range  1.7E +/- 308(15 digits)
        double _myDoubleValue = 12.34;
        double _myDoubleValue2 = 1E06;

        // range -7,9228E+24 to 7,9228E+24
        Decimal _myDecimalValue = 13.234M;

        // type Inference; the getType method returns the variable type.
        public void GetSomeType()
        {
            // double
            Console.WriteLine(3.0.GetType());
            // float
            Console.WriteLine(_myFloatValue.GetType());
        }
        // Method to demostrate an Explicit Cast from float to int.
        public int ConvertFloatToInt(float value)
        {
            int total = (int)value;
            return total;
        }

        // Method to demostrate an IMplicit Cast from int to long.
        public long LongFromInt(int value)
        {
            long total = value;
            return total;
        }

        public void BasicMath()
        {
            int myVal = 5, myOtherVal = 10;

            int addVal = myVal + myOtherVal;
            int subtractVal = myOtherVal - myVal;
            int multiplyVal = myVal * myOtherVal;
            int divisionVal = myVal / myOtherVal;
            int modulusVal = myVal % myOtherVal;

            Console.WriteLine(addVal);
            Console.WriteLine(subtractVal);
            Console.WriteLine(multiplyVal);
            Console.WriteLine(divisionVal);
            Console.WriteLine(modulusVal);
        }
            public void CheckOperators()
        {
            int test = 100, test2 = 100;
            // Checks the expression
            int testVal = checked(test * test2);

            // Checks what in the statement block
            checked
            {
                int testagain = test * 300;
                Console.WriteLine(testagain);
            }
            Console.WriteLine(testVal);
        }
            public void IncrementDecremenet()
        {
            int myValue = 13, myOther = 10;
            //myValue = myValue + 1
            myValue++;
            Console.WriteLine(myValue);
            // myOther = myOther -1;
            myOther--;
            Console.WriteLine(myOther);

            --myValue;
            Console.WriteLine(myValue);

            ++myOther;
            Console.WriteLine(myOther);
        }
       
            public void SpcialValues()
        {
            Console.WriteLine(2.0 / 0.0);
            Console.WriteLine(-2.0 / 0.0);
            Console.WriteLine(2.0 / -0.0);
            Console.WriteLine(-2.0 /-0.0);
            Console.WriteLine(0.0 / 0.0);
            Console.WriteLine((2.0 / -0.0) / (2.0 / 0.0));
            Console.WriteLine(0.0 / -0.0 == double.NaN);
            Console.WriteLine(double.IsNaN (0.0 / 0.0));
            Console.WriteLine(object.Equals(0.0 / -0.0,  double.NaN));
        }

            public void ComparisonOperators()
        {
            bool isCool = true; // declaration of a bool value

            /**bool values can be true or false. No cast type for bool to numeric types */
            int x = 3, y = 5, z = 3;
            Console.WriteLine(x == y); //
            Console.WriteLine(x != y); //
            Console.WriteLine(x == z); //
        }
            public void OtherOprators()
        {
            int vall = 5, val2 = 10;
            // val1 = val1 + val2
            Console.WriteLine(vall += val2);
            Console.WriteLine(vall <<= val2);
        }


    }

}