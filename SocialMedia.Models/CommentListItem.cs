using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class CommentListItem
    {
        public int Id { get; set; }

        public string CommentText { get; set; }

        [Display(Name = "Date Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Date Last Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
