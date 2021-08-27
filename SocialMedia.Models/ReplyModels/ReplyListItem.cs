using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models.ReplyModels
{
    public class ReplyListItem
    {
        [Required]
        public int CommentId { get; set; }
        public string Text { get; set; }     
    }
}
