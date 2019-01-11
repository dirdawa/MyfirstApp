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

        public string Voice
        {

            get
            {
                return _answercall;
            }
            set
            {
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

        public void StartCall(bool isCall)
        {
            if (isCall)
            {
                Console.WriteLine("Start Phone Call.");
            }
            else
            {
                Console.WriteLine("End Phone Call.");
            }
        }

        public CellPhone(string Voice, string answercall)
        {
            this._voice = Voice;
            this._answercall = answercall;
            this._text = Text;
            this._data = Data;
        }


        public void AnswerCall(int speed)
        {
            Console.WriteLine("StartCall at" +speed + "mg per second");
        }

        public void CelllPhone()
        {
            Console.WriteLine("The call start");
        }

        // The following are methods 
        public void CelllPhone(bool isData)
        {
            if (isData)
            {
                Console.WriteLine("Open Browser.");
            }
            else
            {
                Console.WriteLine("Open Multiple Browser.");
            }
        }
    }
}