namespace Quiz
{
    public class DisplayGrade 
    {
        public int Grade(int a)
        {
            myMarks.MarksValue = a.ToString();
            int answer = a;

            return a;

            if (a < 59)
            {
                MessageBox.Show("Fail");
            }
            else if (a >= 60 && a <= 78)
            {
                MessageBox.Show("Average");
            }
            else if (a >= 79 && a <= 89)
            {
                MessageBox.Show("Good");
            }
            else if (a >= 90 && a <= 100)
            {
                MessageBox.Show("Very Good");
            }
            else if (a >= 90 && a <= 100)
            {
                MessageBox.Show("Excellent");
            }
            else
            {
                MessageBox.Show("it is not a valid grade");
            }
            return a;
          
        }
    }
}
    
