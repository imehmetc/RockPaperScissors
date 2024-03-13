/*
 
                                    Rock - Paper - Scissors
 
 */

#region welcomeMessage
Console.ForegroundColor = ConsoleColor.Green;
string welcomeMessage =
@"                          Welcome to the thrilling world of Rock-Paper-Scissors!,
        Prepare to engage in the ultimate battle of wits. To play, simply type 'rock', 'paper', or 'scissors'.
";

Console.WriteLine(welcomeMessage);
Console.ResetColor();
#endregion

int userScore = 0, pcScore = 0;


Random rnd = new Random();

string[] rockPaperScissors = ["Rock", "Paper", "Scissors"];


#region GameLoop
while (userScore != 3 && pcScore != 3)
{
    int randomNumber = rnd.Next(0, 3);

    string pcChoice = rockPaperScissors[randomNumber];
    pcChoice = pcChoice.ToLower();

    #region InputAndHelperFunction

    invalidInput:
    Console.Write("\r\nPlease make your choice: 'rock', 'paper', or 'scissors': ");
    string userChoice = Console.ReadLine();
    userChoice = userChoice.ToLower();

    if (userChoice != "rock" && userChoice != "paper" && userChoice != "scissors")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid choice! Please choose 'rock', 'paper', or 'scissors'.");
        Console.ResetColor();
        goto invalidInput;
    }
    #endregion

    Console.WriteLine($"\r\nYour choice = {userChoice}\r\nComputer choice = {pcChoice}");

    #region RoundResult
    if (userChoice == pcChoice)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\r\nIt's a tie! Nobody wins this round.");
        Console.ResetColor();
    }
    else if ((userChoice == "rock" && pcChoice == "scissors") ||
             (userChoice == "paper" && pcChoice == "rock") ||
             (userChoice == "scissors" && pcChoice == "paper"))
    {
        userScore++;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\r\nYou win this round!");
        Console.ResetColor();
    }
    else
    {
        pcScore++;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\r\nComputer wins this round!");
        Console.ResetColor();
    }

    #endregion

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Your score {userScore}, Computer score {pcScore}");
    Console.ResetColor();
} 
#endregion


#region WinningConditions

if (userScore > pcScore)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\r\n*******************************");
    Console.WriteLine($"\r\nCongratulations! You've won the game!!\r\nYour score {userScore}, Computer score {pcScore}");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\r\n*******************************");
    Console.WriteLine($"\r\nComputer wins! Better luck next time.\r\nYour score {userScore}, Computer score {pcScore}");
    Console.ResetColor();
}
#endregion





Console.ReadKey();