using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace emojis_webapp
{
    public interface IGithubEmojiService
    {
        Task<IList<Emoji>> GetEmojis();
        IList<Emoji> GetEmojisFrom(string content);
    }
}