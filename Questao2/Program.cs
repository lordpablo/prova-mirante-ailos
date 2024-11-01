using Questao2.Integration.Impl;

public class Program
{
    public static void Main()
    {
        string teamName = "Paris Saint-Germain";
        int year = 2013;
        int totalGoals = GetTotalScoredGoals(teamName, year);

        Console.WriteLine("Team " + teamName + " scored " + totalGoals.ToString() + " goals in " + year);

        teamName = "Chelsea";
        year = 2014;
        totalGoals = GetTotalScoredGoals(teamName, year);

        Console.WriteLine("Team " + teamName + " scored " + totalGoals.ToString() + " goals in " + year);

        // Output expected:
        // Team Paris Saint - Germain scored 109 goals in 2013
        // Team Chelsea scored 92 goals in 2014
        // tem alguma coisa errada, quando joga a URL no postman independente do Ano o PSG e qualquer outro time tem sempre
        // a mesma quantidade de gols independente do ano, mas quando fazemos por integração a quantidade muda. Aí o resultado não bate.
    }

    public static int GetTotalScoredGoals(string team, int year)
    {
        int totalGoals = 0;
        var footballApi = new FootballApi();
        bool exit = false;
        int page = 1;
        int totalPages = 0;
        while (!exit)
        {
            var matches = footballApi.ReturnMatches(year, team, page);
            if (matches != null)
            {
                totalPages = matches.TotalPages;
                totalGoals += matches.Data.Sum(x => Convert.ToInt32(x.Team1goals));
            }
            else return totalGoals;
            if (page == totalPages) exit = true;
            page++;
        }

        return totalGoals;
    }

}