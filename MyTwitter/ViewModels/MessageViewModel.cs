using MyTwitter.Models;
using System.Collections.Generic;

namespace MyTwitter.ViewModels
{
    public class MessageViewModel
    {
        public PostMessage Msg { get; set; }
        public IEnumerable<PostMessage> Messages { get; set; }
    }
}
