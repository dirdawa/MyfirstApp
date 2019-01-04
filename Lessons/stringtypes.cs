using System;
using System.Text;


namespace Lessons
{
    public class stringtypes
    {
        private string _testString = "Test String";
        private string _secondString = "Second String";

        public void SamplesString()
        {
            Console.WriteLine(_testString);
        }

        public void AddString()
        {
            Console.WriteLine(_testString + _secondString);
        }

        public string StringBuilderExample(String value1,
        string value2, string value3)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(value1)
            .Append(" ").Append(value2)
            .Append(" ").Append(value3);

            return builder.ToString();
        }

        public void CharTypExamples()
        {
           	char ab = 'A'; 
           	char de = 'B'; 
         	char copyrightSymbol = '\u00A9'; 
           	char hi = (char)88; 

          	Console.WriteLine(hi);
            Console.WriteLine(ab == de); 
          	Console.WriteLine("The copyright symbol looks like {0}", copyrightSymbol);
        }

    }
}