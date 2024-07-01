namespace pwaApp.Services
{
    public class UserService : IUserService
    {
        private string _username;

        public string Username => _username;

        public void SetUsername(string username)
        {
            _username = username;
        }
    }
}
