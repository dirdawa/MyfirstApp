using System;
namespace Quiz
{
    public class LabResults
    {
        static void LabResultsExamples(int argc, const char* argv[]) 
            {
            int V, I, R;

            printf("please enter the value of the current if the value is not known make I=0 ");
            canf("%d", &I);
            printf("please entre the value of the resistance if the value is not known make R=0");
            scanf("%d", &R);
            printf("please enter the value of the voltage, if unknown make V=0");
            scanf("%d", &V);

            if (V == 0)

        
                V = I* R;
            printf(" V = %d", V);
            }
                else if (I == 0)
                I = V / R;
            {
                printf("     R = V / I);
                printf("R= %d", R);

                return 0;
            }

                
        }
    }
}

