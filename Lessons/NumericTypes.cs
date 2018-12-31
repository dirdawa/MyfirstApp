using System;
using Lessons;
{
    public class NumericTypes
    {
        /*Integral - Signed */
        // rang 128 - 127
        sbyte _mySbyteValue = 1;

        // rang -32,768 - 32,767
        short _myShortValue =4;

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
    }
}