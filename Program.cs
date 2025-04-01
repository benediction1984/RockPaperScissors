
//Rock Paper Scissors
string[] playerChoice = new[] { "rock", "paper", "scissors" };

Console.WriteLine("Pick one of the selection: Rock, Paper, Scissors");
string playerInput = Console.ReadLine().Trim().ToLower();


Random rdm = new Random();
string computerOpponentInput = playerChoice[rdm.Next(0, playerChoice.Length)];

if (playerInput == computerOpponentInput)
{
    Console.WriteLine("It's a tie.");
}
else if (playerInput == "rock"     &&  computerOpponentInput == "scissors" ||
         playerInput == "scissors" &&  computerOpponentInput == "paper" ||
         playerInput == "paper"    &&  computerOpponentInput == "rock")
{
    Console.WriteLine($"You win! {playerInput.ToUpper()} beats {computerOpponentInput.ToUpper()}. Congratulations.");
}
else
{
    Console.WriteLine($"You lose! {computerOpponentInput.ToUpper()} beats {playerInput.ToUpper()}. Better luck next time. ");

}