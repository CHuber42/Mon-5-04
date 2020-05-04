using System;

class pingpong{
    static void Main()
    {
        Console.WriteLine("Give me a number, and I will play Ping-Pong with you!");
        string stringNumber = Console.ReadLine();  
        int yourNumber = int.Parse(stringNumber);  
        int ping = 3;
        int pong = 5;



        for (int i = 1; i <= yourNumber; i++)
        {
            if (i%ping == 0 && i%pong == 0) {
                Console.WriteLine("ping-pong");
            }
            else if (i%pong == 0) {
                Console.WriteLine("pong");
            }
            else if (i%ping == 0) {
                Console.WriteLine("ping");
            }
            else {
                Console.WriteLine(i);
            }
        }
    }
}