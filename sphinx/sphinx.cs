using System;

class queenattack{
    static void Main()
    {

        Random rand = new Random();


        int[] riddles = {1, 2, 3};
        for (int i = 0; i < 3; i++){
            int j = rand.Next(i, 3);
            int k = riddles[i];
            riddles[i] = riddles[j];
            riddles[j] = k;
        }

        string response;
        bool dead = false;

        foreach (var riddle in riddles)
        {
            if (!dead){
                switch(riddle)
                {
                    case 1:
                        Console.WriteLine("You stand before a sphinx. It asks: 'What do I have in my pocket?'");
                        response = Console.ReadLine();
                        if (response != "ring") {
                            Console.WriteLine("The sphinx yells 'Wrong!' and eats you.");
                            dead = true;
                        }
                        else {
                            Console.WriteLine("The sphinx yells 'Right!'");
                        }
                        break;
                    case 2:
                        Console.WriteLine("You stand before a sphinx. It asks: 'What walks on four legs in the morning, two in the afternoon, and three in the evening?'");
                        response = Console.ReadLine();
                        if (response != "human") {
                            Console.WriteLine("The sphinx yells 'Wrong!' and eats you.");
                            dead = true;
                        }
                        else {
                            Console.WriteLine("The sphinx yells 'Right!'");
                        }
                        break;
                    case 3:
                        Console.WriteLine("You stand before a sphinx. It asks: 'flight or invisibility?'");
                        response = Console.ReadLine();
                        if (response != "invisibility") {
                            Console.WriteLine("The sphinx yells 'Wrong!' and eats you.");
                            dead = true;
                        }
                        else {
                            Console.WriteLine("The sphinx yells 'Right!'");
                        }
                        break;
                }
            }
        }

        if (!dead) {
            Console.WriteLine("The sphinx says: 'You have answered all my riddles. You may go.'");
        }
        else {
            Console.WriteLine("The sphinx says: 'Yum'.");
        }

   
    } //main
}