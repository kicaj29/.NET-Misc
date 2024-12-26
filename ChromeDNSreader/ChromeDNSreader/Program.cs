// See https://aka.ms/new-console-template for more information
using ChromeDNSreader;
using System.Text.Json;

Console.WriteLine("Starting...");

string jsonString = File.ReadAllText("poki.com.har.json");

RootModel rootModel = JsonSerializer.Deserialize<RootModel>(jsonString,
    new JsonSerializerOptions()
    {
        PropertyNameCaseInsensitive = true
    }) ?? throw new InvalidOperationException();

List<string> urls = rootModel.Log.Entries.Select(entry => entry.Request.Url).ToList();

HashSet<string> domains = [];

foreach (string url in urls)
{
    int startIndex = url.IndexOf("://") + 3;
    string tmp = url.Substring(startIndex);
    int endIndex = tmp.IndexOf('/');
    tmp = tmp.Substring(0, endIndex);
    if (!domains.Contains(tmp))
    {
        domains.Add(tmp);
    }
}

foreach (string domain in domains)
{
    Console.WriteLine(domain);
}

Console.WriteLine("Finished");
