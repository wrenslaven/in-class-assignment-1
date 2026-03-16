using System.Collections.Generic;

Dictionary<string, string> countryCapitals = new Dictionary<string, string>();
countryCapitals.Add("Gabon", "Libreville");
countryCapitals.Add("Burkina Faso", "Ouagadougou");
countryCapitals.Add("Mozambique", "Maputo");
countryCapitals.Add("Sudan", "Khartoum");

List<string> countries = new List<string>()
{
    "Gabon",
    "Burkina Faso",
    "Mozambique"
};

int score = 0;
int question_num = 1;

Console.WriteLine("Welcome to the African capitals quiz! All answers are case-sensitive!");

foreach (KeyValuePair<string, string> countryCapitalPair in countryCapitals)
{
    Console.WriteLine($"Question {question_num}: What's the capital of {countryCapitalPair.Key}?");

    string q1_input = Console.ReadLine();
    if (q1_input == countryCapitalPair.Value) {
        Console.WriteLine("That's correct!");
        score++;
    }
    else
    {
        Console.WriteLine($"That's incorrect. The capital of {countryCapitalPair.Key} is {countryCapitalPair.Value}.");
    }
    question_num++;
}

Console.WriteLine($"That's the end of the quiz. Your final score is {score} out of {countryCapitals.Count}");