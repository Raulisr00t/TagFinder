using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.Write("Enter URL (e.g., https://example.com): ");
        string url = Console.ReadLine();

        Console.Write("Enter tag to search for (without <>, e.g., a, img, div): ");
        string tag = Console.ReadLine();

        try
        {
            using HttpClient client = new HttpClient();
            string output = await client.GetStringAsync(url);

            ScrapeTag(output, tag);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching URL: {ex.Message}");
        }
    }

    static void ScrapeTag(string html, string tag)
    {
        string pattern = $@"<\s*{tag}[^>]*>";

        MatchCollection matches = Regex.Matches(html, pattern, RegexOptions.IgnoreCase);

        foreach (Match match in matches)
        
            Console.WriteLine($"[+] FOUND <{tag}> tag: {match.Value}");
        
        if (matches.Count == 0)
        
            Console.WriteLine($"[-] No <{tag}> tags found.");
        
    }
}
