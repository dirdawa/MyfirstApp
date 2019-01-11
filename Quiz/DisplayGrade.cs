namespace Quiz
{
    public class DisplayGrade 
    {
       public string SampleSwitch(string grade)
        {
            if  (grade == "F")
            {
                return ("Fail");
            }
            else if (grade == "A")
            {
                return ("Average");
            }
            else if (grade == "G")
            {
                return ("Good");
            }
            else if (grade == "V")
            {
                return ("Very Good");
            }
            else if (grade == "E")
            {
                return "Excellent";
            }
            else
            {
                return "it is not a valid grade";
            }
            
          
        }
    }
}
    
