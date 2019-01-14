using System;
namespace classwork
{
    public class RanchStyle : House
    {
        public RanchStyle(string foudation, string window, string roof, string doorpaint)
        : base(founsaion, windows, roof, doorpaint)
        {
            Console.writeLine("Ranch Style Constractor");
        }
        public RanchStyle(string foudation, string window)
        : base(founsaion, windows)
        {
            Console.WriteLine("Ranch Style Constractor");
        }
    }
}
