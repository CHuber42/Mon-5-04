using System;

class clockangle{
    static void Main()
    {
        Console.WriteLine("Give me a time in the format 'hours (0-12):Minutes (0-59)', and I will find the angle between the clock hands at that point in time.");
        string timeInput = Console.ReadLine();  
        
        String[] strList = timeInput.Split(":");

        float hours = float.Parse(strList[0]);
        float minutes = float.Parse(strList[1]);

        float hoursAngle = ((hours + (minutes/60))/12) * 360;
        float minutesAngle = (minutes / 60) * 360;

        float clockwiseAngle; 
        if (minutesAngle > hoursAngle){
            clockwiseAngle = minutesAngle - hoursAngle;
        }
        else {
            clockwiseAngle = hoursAngle - minutesAngle;
        }

        float ccwAngle = 360 - clockwiseAngle;
        if (ccwAngle > clockwiseAngle){
            Console.WriteLine("The angle between them is: " + clockwiseAngle.ToString() + " degrees.");
        }
        else {
            Console.WriteLine("The angle between them is: " + ccwAngle.ToString() + " degrees.");
        }
    }
}