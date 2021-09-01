using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class CommentListItem
    {
        public int PostId { get; set; }

        public string CommentText { get; set; }

        //might want to include owner here

    }  
}
