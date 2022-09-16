using System.ComponentModel.DataAnnotations;

namespace sign
{
    public class User
    {
        //public int Id { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string Username { get; set; }
        //public byte[] PasswordHash { get; set; }
        //public byte[] PasswordSalt { get; set; }
       [Key] 
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int Mobile { get; set; }
        public string? Password { get; set; }
    }
}