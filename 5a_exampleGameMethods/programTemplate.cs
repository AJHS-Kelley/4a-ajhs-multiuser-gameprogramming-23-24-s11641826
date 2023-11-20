// Albert  Laguerre, Program Template, v0.01
using System

namespace UPDATEFOREACHPROGRAM
{
    class UPDATEFOREACHPROGRAM

    {
        int shakeDice = 3; 
        int bettingAmount = ''
        int numberofDice = 2
        
        static void shakeDice()
        {
           
        }  

        static void rollDice()
        {
                rollDice(numDice, sizeDice):
                 numRolled = 0
                sum = 0
                while numRolled < numDice:
                roll = random.randint(1, sizeDice)
                sum += roll
                print(f"Roll: {roll}\n")
                print(f"Sum: {sum}\n")
                numRolled += 1
                
                diceRoll = random.randint(1, 6)
                return diceRoll
        }

        static void bettingAmount()
        {

        }

        static void numberofDice()
        {
            numberofDice = 2
            sum = 2
        }

        static void rounds()
        {
            print("Round " + str(rounds))
        player1 = rollDice()
        player2 = rollDice()
        print("Player 1 Roll: " + str(player1))
        print("Player 2 Roll: " + str(player2))

        if player1 == player2:
            print("Draw!")
        elif player1 > player2:
            player1wins = player1wins + 1
            print("Player 1 wins!")
        else:
            player2wins = player2wins + 1
            print("Player 2 wins!")
    
            rounds = rounds + 1 

        if player1wins == player2wins:
            print("Draw!")
        elif player1wins > player2wins:
            print("Player 1 Wins! ")
        else:
            print("Player 2 Wins! ")
        }
    }
}