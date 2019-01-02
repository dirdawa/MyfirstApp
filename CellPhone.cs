using System;
namespace classwork
{
    public class CellPhone

    {
        // The following are fields
        string _voice;
        string _answercall;
        string _data;
        string _text;

        public string Voice {
        
            get {
                return _answercall;
            }
            set {
                this._answercall = value;
            }
        }

        public void StartCall()
        {
        Console.WriteLine("startcall");
        }


        public void EndCall()
        {
        Console.WriteLine("endcall");
        }



        // The following are Method

        public string Data
        {
            get
            {
                return _data;
            }
            set
            {
                this._data = value;
            }
        }

       
        // The following are Method
        public string Text { get; set; }
        
    }
}