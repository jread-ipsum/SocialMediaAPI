using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class CommentCreate
    {
        [Required]
        [MinLength(4, ErrorMessage = "Please enter at least 4 characters.")]
        [MaxLength(1000, ErrorMessage = "Comments have a maximum length of 1000 characters.")]
        public string CommentText { get; set; }
        public int PostId { get; set; }
    }
}
