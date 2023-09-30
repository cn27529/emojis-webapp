using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System;

namespace emojis_webapp.Pages;


public class EmojisModel : PageModel
{
    //private IGithubEmojiService _GithubEmojiService;

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

    }


    public IList<Emoji> Emojis { get; set; }


    public async Task OnGet()
    {
        Emojis = new List<Emoji>();
        var _emojiService = new GithubEmojiService();
        Emojis = await _emojiService.GetEmojis();
    }
}
