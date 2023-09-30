using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace emojis_webapp.Pages;


public class EmojisModel : PageModel
{
    //private readonly IGithubEmojiService _GithubEmojiService;

    // public EmojisModel()
    // {

    // }
    // public EmojisModel(IGithubEmojiService myGithubEmojiService)
    // {
    //     _GithubEmojiService = myGithubEmojiService;
    // }

    private readonly ILogger<EmojisModel> _logger;
    //private readonly IGithubEmojiService<GithubEmojiService> _emojiService;

    public EmojisModel(ILogger<EmojisModel> logger)
    {
        _logger = logger;
        IGithubEmojiService svc = new GithubEmojiService();
        //return model = svc.GetEmojis();
    }



    public void OnGet()
    {
    }
}
