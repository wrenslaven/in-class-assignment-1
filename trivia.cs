using System.Text;
using System.Globalization;

TriviaGame.PlayGame();

public static class TriviaGame
{
    public static string RemoveDiacritics(string text) 
    // Source - https://stackoverflow.com/a/249126
    // Posted by Blair Conrad, modified by community. See post 'Timeline' for change history
    // Retrieved 2026-03-17, License - CC BY-SA 4.0
    {
        var normalizedString = text.Normalize(NormalizationForm.FormD);
        var stringBuilder = new StringBuilder(capacity: normalizedString.Length);

        for (int i = 0; i < normalizedString.Length; i++)
        {
            char c = normalizedString[i];
            var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
            if (unicodeCategory != UnicodeCategory.NonSpacingMark)
            {
                stringBuilder.Append(c);
            }
        }

        return stringBuilder
            .ToString()
            .Normalize(NormalizationForm.FormC);
    }
    public static string PlayGame()
    {
        Dictionary<string, string> countryCapitals = new Dictionary<string, string>()
        {
            ["Algeria"] = "Algiers",["Angola"] = "Luanda",
            ["Benin"] = "Porto-Novo",["Botswana"] = "Gaborone",
            ["Burkina Faso"] = "Ouagadougou",["Burundi"] = "Gitega",
            ["Cabo Verde"] = "Praia",["Cameroon"] = "Yaoundé",
            ["Central African Republic"] = "Bangui",["Chad"] = "N'Djamena",
            ["Comoros"] = "Moroni",["Democratic Republic of the Congo"] = "Kinshasa",
            ["Republic of the Congo"] = "Brazzaville",["Djibouti"] = "Djibouti City",
            ["Egypt"] = "Cairo",["Equatorial Guinea"] = "Malabo",
            ["Eritrea"] = "Asmara",["Eswatini"] = "Mbabane", // Lobamba should also be accepted
            ["Ethiopia"] = "Adis Ababa",["Gabon"] = "Libreville",
            ["Gambia"] = "Banjul",["Ghana"] = "Accra",
            ["Guinea"] = "Conakry",["Guinea-Bissau"] = "Bissau",
            ["Cote d'Ivoire"] = "Yamoussoukro",["Kenya"] = "Nairobi",
            ["Lesotho"] = "Maseru",["Liberia"] = "Monrovia",
            ["Libya"] = "Tripoli",["Madagascar"] = "Antananarivo",
            ["Malawi"] = "Lilongwe",["Mali"] = "Bamako",
            ["Mauritania"] = "Nouakchott",["Mauritius"] = "Port Louis",
            ["Morocco"] = "Rabat",["Mozambique"] = "Maputo",
            ["Namibia"] = "Windhoek",["Niger"] = "Niamey",
            ["Nigeria"] = "Abuja",["Rwanda"] = "Kigali",
            ["Sao Tome and Principe"] = "São Tomé",["Senegal"] = "Dakar",
            ["Seychelles"] = "Victoria",["Sierra Leone"] = "Freetown",
            ["Somalia"] = "Mogadishu",["South Africa"] = "Pretoria", // Cape Town should also be accepted
            ["South Sudan"] = "Juba",["Sudan"] = "Khartoum",
            ["Tanzania"] = "Dodoma",["Togo"] = "Lomé",
            ["Tunisia"] = "Tunis",["Uganda"] = "Kampala",
            ["Zambia"] = "Lusaka",["Zimbabwe"] = "Harare",
        };
        
        int score = 0;
        int question_num = 1;
        Console.WriteLine("Welcome to the African capitals quiz!");

        foreach (KeyValuePair<string, string> countryCapitalPair in countryCapitals)
        {
            Console.WriteLine($"Question {question_num++}: What's the capital of {countryCapitalPair.Key}?");

            string input = Console.ReadLine();
            string cleaned_input = RemoveDiacritics(input);
            string cleaned_answer = RemoveDiacritics(countryCapitalPair.Value);

            if (string.Equals(cleaned_input, cleaned_answer, StringComparison.CurrentCultureIgnoreCase)){
                Console.WriteLine("That's correct!");
                score++;
            }
            else
            {
                Console.WriteLine($"That's incorrect. The capital of {countryCapitalPair.Key} is {countryCapitalPair.Value}.");
            }
        }

        Console.WriteLine($"That's the end of the quiz. Your final score is {score} out of {countryCapitals.Count}");
        return null;
    }
}