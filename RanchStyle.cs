using System;
namespace classwork
{
    public class RanchStyle : House
    {
        public RanchStyle(string foudation, string windows, string roof, string doorpaint)
        : base(foudation, windows, roof, doorpaint)
        {
            Console.WriteLine("Ranch Style Constractor");
        }
        public RanchStyle(string foudation, string windows)
        : base(foudation, windows)
        {
            Console.WriteLine("Ranch Style Constractor");
        }
    }
}
