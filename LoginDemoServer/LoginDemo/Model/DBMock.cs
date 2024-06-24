namespace LoginDemo.Model
{
    public class DBMock
    {
        public List<User> users { get; set; }

        public DBMock()
        {
            users = new List<User>
            {
                new User { id = 1, FirstName = "abed", LastName = "jaber", Email = "abdo.jaber.123@gmail.com" , Password = "11111@" },
                new User { id = 2, FirstName = "yosef", LastName = "taweel", Email = "ydodgdiu.99@gmail.com" , Password = "22222@" },

            };
        }
    }
}
