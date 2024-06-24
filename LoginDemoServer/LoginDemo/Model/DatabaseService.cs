namespace LoginDemo.Model
{
    public class DatabaseService
    {
        private readonly DBMock _dbMock;

        public DatabaseService()
        {
            _dbMock = new DBMock();
        }

        public User AuthenticateUser(string email, string password)
        {
            return _dbMock.users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}
