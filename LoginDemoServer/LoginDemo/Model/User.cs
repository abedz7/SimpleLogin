namespace LoginDemo.Model
{
    public class User
    {
        public int id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"User -> id : {id} FirstName : {FirstName}  LastName : {LastName}  Email : {Email}  Password : {Password}";
        }
    }
}
