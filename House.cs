using System;
namespace classwork
{
    // public refers to viewing ability
    public class House
    {
        // The following are fields or variables
        string _foundation;
        //string _roof;
        string _window;
        //string _door;

        //Standard long way of a Property
        public string Foundation
        {
            get
            {
                return _foundation;
            }
            set
            {
                this._foundation = value;
            }
        }

        public string Window
        {
            get
            {
                return _window;
            }
            set
            {
                this._window = value;
            }
        }

        public string PaintDoor { get; set; }

        // Short handhand property + field
        public string Roof { get; set; }

        public House() { }

        public House(string foundation, string window)
        {
            this._foundation = foundation;
            this._window = window;
            this.Roof = "shingles";
            this.PaintDoor = "Green";
        }



        public House(string foundation, string window, string Roof, string DoorPaint)
        {
            this._foundation = foundation;
            this._window = window;
            this.Roof = Roof;
            this.PaintDoor = DoorPaint;
        }

        // The following are Methods
        public void OpenDoor()
        {
            Console.WriteLine("The door opens");
        }

        public void CloseDoor()
        {
            Console.WriteLine("The door closes");
        }
        
        // The following are methods 
        public void OpenDoor(bool isExterior)
        {
            if (isExterior)
            {
                Console.WriteLine("Open Front Door.");
            }
            else
            {
                Console.WriteLine("Open Bedroom Door.");
            }
            
        }
        
    }
}