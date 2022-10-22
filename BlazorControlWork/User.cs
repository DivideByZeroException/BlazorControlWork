using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BlazorControlWork
{
    public class User
    {
        private string login;
        private string password;
        private string firstName;
        private string lastName;
        private string email;
        [BsonId]
        public ObjectId Id { get; set; }
        public User(string login, string password, string firstName, string lastName, string email)
        {
            Login = login;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            
        }

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
    }
    

}
