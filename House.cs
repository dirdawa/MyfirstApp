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
        public string Foundation {
            get {
                return _foundation;
            }
            set{
                this._foundation = value;
            }
        }

        public string Window {
            get{
                return _window;
            }
            set{
                this._window = value;
            }
        }

        public string PaintDoor {get; set;}

        // Short handhand property + field
        public string Roof {get; set;}

        // The following are methods or functions
        public void OpenDoor() {

         }

        public void CloseDoor() {

         }
    }
}