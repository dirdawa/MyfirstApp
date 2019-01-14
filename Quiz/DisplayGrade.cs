using System;
namespace Quiz
{
    public class DisplayGrade
    {
        public string grade(string grade)
        {
            
            switch (grade)
            {

            case "F":

                return "Fail";

            case "A":

                return "Average";

            case "G":

                return "Good";

            case "V":

                return "Very Good";

            case "E":

                return "Excellent";

            default:

                return "it is not a valid grade";
            }
            
        }
    }

}
