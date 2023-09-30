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

## new packages
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
