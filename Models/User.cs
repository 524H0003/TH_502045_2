namespace TH_502045_2.Models
{
    public class User
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool Lock { get; set; } // true nếu tài khoản bị khóa
    }
}
