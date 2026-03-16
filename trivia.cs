Console.WriteLine("Welcome to the African capitals quiz!");
Console.WriteLine("Question 1: What's the capital of Gabon?");
int score = 0;
string q1_input = Console.ReadLine();
string q1_answer = "Libreville";
if (q1_input == q1_answer) {
    Console.WriteLine("That's correct!");
    score++;
}
else
{
    Console.WriteLine($"That's incorrect. The capital of Gabon is {q1_answer}.");
}

Console.WriteLine("Question 2: What's the capital of Burkina Faso?");
string q2_input = Console.ReadLine();
string q2_answer = "Ouagadougou";
if (q2_input == q2_answer){
    Console.WriteLine("That's correct!");
    score++;
}
else
{
    Console.WriteLine($"That's incorrect. The capital of Gabon is {q2_answer}.");
}

Console.WriteLine("Question 3: What's the capital of Mozambique?");
string q3_input = Console.ReadLine();
string q3_answer = "Maputo";
if (q3_input == q3_answer){
    Console.WriteLine("That's correct!");
    score++;
}
else
{
    Console.WriteLine($"That's incorrect. The capital of Gabon is {q3_answer}.");
}

Console.WriteLine($"That's the end of the quiz. Your final score is {score} out of 3.");