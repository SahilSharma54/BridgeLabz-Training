using System;

class SnakeAndLadder{

    // Function to roll dice
    static int RollDice(){
        Random random=new Random();
        return random.Next(1,7);
    }

    // Function to move player
    static int MovePlayer(int position,int dice){
        if(position+dice>100){
            return position;
        }
        return position+dice;
    }

    // Function to apply snake or ladder
    static int ApplySnakeOrLadder(int position,int[,] board){
        for(int i=0;i<board.GetLength(0);i++){
            if(board[i,0]==position){
                return board[i,1];
            }
        }
        return position;
    }

    // Function to check winner
    static bool CheckWin(int position){
        return position==100?true:false;
    }

    static void Main(string[] args){

        Console.WriteLine("Enter number of players (2 to 4):");
        int playersCount=int.Parse(Console.ReadLine());

        if(playersCount<2||playersCount>4){
            Console.WriteLine("Invalid number of players");
            return;
        }

        string[] players=new string[playersCount];
        int[] positions=new int[playersCount];

        for(int number=0;number<playersCount;number++){
            Console.WriteLine("Enter player name:");
            players[number]=Console.ReadLine();
            positions[number]=0;
        }

        // 2D array for snakes and ladders
        int[,] board={
            {4,14},
            {9,31},
            {17,7},
            {20,38},
            {28,84},
            {40,59},
            {51,67},
            {54,34},
            {62,19},
            {64,60},
            {71,91},
            {87,24},
            {93,73},
            {95,75},
            {99,78}
        };

        bool gameOver=false;

        while(!gameOver){
            for(int iterator=0;iterator<playersCount;iterator++){

                Console.WriteLine("Press Enter to roll dice");
                Console.ReadLine();

                int dice=RollDice();
                int oldPosition=positions[iterator];

                int newPosition=MovePlayer(oldPosition,dice);
                int finalPosition=ApplySnakeOrLadder(newPosition,board);

                positions[iterator]=finalPosition;

                Console.WriteLine("Player: "+players[iterator]);
                Console.WriteLine("Dice: "+dice);
                Console.WriteLine("Position: "+oldPosition+" -> "+finalPosition);

                if(newPosition!=finalPosition){
                    if(finalPosition>newPosition){
                        Console.WriteLine("Ladder");
                    }
                    else{
                        Console.WriteLine("Snake");
                    }
                }

                if(CheckWin(finalPosition)){
                    Console.WriteLine(players[iterator]+" Wins the Game");
                    gameOver=true;
                    break;
                }
            }
        }
    }
}
