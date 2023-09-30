# emojis-webapp
dotnet core webapp read github emojis api

# learn emojis from resouce
https://learn.microsoft.com/zh-tw/visualstudio/mac/tutorial-aspnet-core-vsmac-getting-started?view=vsmac-2022

## yt here 
https://www.youtube.com/watch?v=2CsZpJdFFnQ&t=161s

## github emojis
https://docs.github.com/en/free-pro-team@latest/rest/emojis/emojis?apiVersion=2022-11-28

## emojis api url here
https://api.github.com/emojis

# Step by step

## add package 新增 NuGet 套件和 EF 工具
```bash=
dotnet tool uninstall --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Newtonsoft.Json
```

## Create a Emoji Class
```cs=
namespace emojis_webapp;
public class Emoji
{
    public string Key { get; set; }
    public string Url { get; set; }
}
```

## Create a GithubEmojiService Class
```cs=
namespace emojis_webapp;
public class GithubEmojiService
{
    const string GithubEmojiUrl = "https://api.github.com/emojis";
    private readonly HttpClient _httpClient;
    private IList<Emoji> _emojis;

    public GithubEmojiService()
    {
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "sayedihashimi-github-emojis");
    }

    public async Task<IList<Emoji>> GetEmojis()
    {
        if (_emojis == null || _emojis.Count <= 0)
        {
            var emojiStr = await _httpClient.GetStringAsync(GithubEmojiUrl);
            try
            {
                _emojis = GetEmojisFrom(emojiStr);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"error: {ex.ToString()}");
            }
        }

        return _emojis;
    }

    public IList<Emoji> GetEmojisFrom(string content)
    {
        var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);
        var results = new List<Emoji>();

        foreach (var key in dictionary.Keys)
        {
            if (string.IsNullOrWhiteSpace(key)) { continue; }

            results.Add(new Emoji
            {
                Key = key,
                Url = dictionary[key]
            });
        }

        return results;
    }
}
```



