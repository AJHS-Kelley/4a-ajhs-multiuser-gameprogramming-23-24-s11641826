Albert Laguerre, Program Template, v0.01
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Dice Game!");

        Random random = new Random();
        int player1Score = 0;
        int player2Score = 0;

        for (int round = 1; round <= 3; round++)
        {
            Console.WriteLine($"\nRound {round}");

            Console.WriteLine("Player 1, press Enter to roll the dice...");
            Console.ReadLine();
            int dice1 = random.Next(1, 7);
            Console.WriteLine($"Player 1 rolled a {dice1}");
            player1Score += dice1;

