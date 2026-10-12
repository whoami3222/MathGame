string question1 = "What is 5 + 3";
string question2 = "What is 10 - 4";
string question3 = "What is 6 * 7";
string question4 = "What is 15 / 3";
string question5 = "What is 2 ^ 8";
string[] questions = [question1, question2, question3, question4, question5];
int points = 0;
List<string> history = new List<string>();
MathGame();


void MathGame()
{
    DisplayMenu();
    string? input = Console.ReadLine();
    HandleMenuChoice(input);

}

void DisplayMenu()
{
    Console.WriteLine("Choose from the menu below:");
    Console.WriteLine("1. Start Game");
    Console.WriteLine("2. Display History");
    Console.WriteLine("3. Exit");
}

void HandleMenuChoice(string? choice)
{
    switch (choice)
    {
        case "1":
            StartGame();
            break;
        case "2":
            DisplayList();
            break;
        case "3":
            Console.WriteLine("Exiting the game. Goodbye!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}

void StartGame()
{
    for (int i = 0; i < questions.Length; i++)
    {
        Console.WriteLine(questions[i]);
        string? input = Console.ReadLine();
        if (CheckAnswer(questions[i], input))
        {
            points++;
        }
    }

    Console.WriteLine($"You scored {points} out of {questions.Length}.");
    history.Add($"Game played on {DateTime.Now}: Scored {points}/{questions.Length}");
    PlayAgainPrompt();
}

void PlayAgainPrompt()
{
    Console.WriteLine("Do you want to return to the menu? (yes/no)");
    string? playAgain = Console.ReadLine();
    if (playAgain?.ToLower() == "yes")
    {
        points = 0; // Reset points for a new game
        MathGame();
    }
    else if(playAgain?.ToLower() == "no")
    {
        Console.WriteLine("Thank you for playing!");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Invalid input, try again.");
        PlayAgainPrompt();
    }
}

void DisplayList()
{
    Console.WriteLine("History of previous games:");
    foreach (string item in history)
    {
        Console.WriteLine($"- {item}");
    }

    PlayAgainPrompt();
}

bool CheckAnswer(string question, string answer)
{
    switch (question)
    {
        case "What is 5 + 3":
            return answer == "8";
        case "What is 10 - 4":
            return answer == "6";
        case "What is 6 * 7":
            return answer == "42";
        case "What is 15 / 3":
            return answer == "5";
        case "What is 2 ^ 8":
            return answer == "256";
        default:
            return false;
    }
}