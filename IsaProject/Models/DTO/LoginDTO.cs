namespace IsaProject.Models.DTO
{
    public class LoginDTO
    {
        public string username { get; set; }
        public string password { get; set; }

        public LoginDTO(string Username, string Password)
        {
            username = Username;
            password = Password;
        }
    }
}
