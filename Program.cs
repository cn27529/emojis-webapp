using emojis_webapp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//https://learn.microsoft.com/zh-tw/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-7.0
//.NET Core 中的相依性插入
//builder.Services.AddSingleton<IGithubEmojiService, GithubEmojiService>();
//builder.Services.AddSingleton<GithubEmojiService>(sp => ActivatorUtilities.CreateInstance<GithubEmojiService>(sp));
//builder.Services.AddScoped<IGithubEmojiService, GithubEmojiService>();
builder.Services.AddMyDependencyGroup();

//builder.Services.AddSingleton<IGithubEmojiService>(sp => new GithubEmojiService(sp.GetRequiredService<IGithubEmojiService>()));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

//app.UseMyMiddleware();
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
