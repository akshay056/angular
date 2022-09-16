using System.ComponentModel.DataAnnotations;

namespace signupApi.Models
{
    public class userlist
    {
        [Key]
        public string email { get; set; }
        public string password { get; set; }
    }
}
