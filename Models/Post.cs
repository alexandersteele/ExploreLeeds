using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ExploreLeeds.Models
{
    public class Post
    {
        public long Id { get; set; }

        public string _key;

        public string Key
        {
            get
            {
                if (_key == null)
                {
                    _key = Regex.Replace(Title.ToLower(), "[^a-z0-9]", "-");
                }
                return _key;
            }
            set { _key = value; }
        }

        [Display(Name = "Post Title")]
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Must be between 5 and 100 characters")]
        public string Title { get; set; }

        public string Author { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [MinLength(100, ErrorMessage = "Must be at least 100 characters")]
        public string Body { get; set; }

        public DateTime Posted { get; set; }
    }
}
