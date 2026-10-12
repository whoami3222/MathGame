string question1 = "What is 5 + 3";
string question2 = "What is 10 - 4";
string question3 = "What is 6 * 7";
string question4 = "What is 15 / 3";
string question5 = "What is 2 ^ 8";

string[] questions = [question1, question2, question3, question4, question5];
int points = 0;

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