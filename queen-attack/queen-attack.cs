using System;

class queenattack{
    static void Main()
    {
        Console.WriteLine("Give me the X/Y coordinates for the queen in the format 'X, Y'.");
        String[] queenCoordString = (Console.ReadLine()).Split(",");
        Console.WriteLine("Give me the X/Y coordinates of a different piece in the format 'X, Y'.");
        String[] otherPieceCoordString = (Console.ReadLine()).Split(",");

        int[] queenCoords = {int.Parse(queenCoordString[0]), int.Parse(queenCoordString[1])};
        int[] pieceCoords = {int.Parse(otherPieceCoordString[0]), int.Parse(otherPieceCoordString[1])};

        if (queenCoords[0] == pieceCoords[0] || queenCoords[1] == pieceCoords[1] || Math.Abs(queenCoords[0] - pieceCoords[0]) == Math.Abs(queenCoords[1] - pieceCoords[1]))
        {
            Console.WriteLine("Queen can attack.");
        }
        else 
        {
            Console.WriteLine("Queen can't attack");
        }
    
    }
}