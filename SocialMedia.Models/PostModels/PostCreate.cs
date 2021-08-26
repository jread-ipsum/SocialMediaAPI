using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models.PostModels
{
    public class PostCreate
    {
        // Do I need an  public int Id { get; set;} Here?
        [Required]        
        [MinLength(5, ErrorMessage = "Please enter at least 5 characters.")]
        [MaxLength(25, ErrorMessage = "You can have NO more than 25 characters.")]
        public string Title { get; set; }

        [MaxLength(8000)]
        public string Text { get; set; }
    }
}
