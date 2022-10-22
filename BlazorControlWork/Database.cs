using MongoDB.Driver;

namespace BlazorControlWork
{
    public class Database
    {
        public static string AddToDB(User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("BlazorControlWork");
            var collection = database.GetCollection<User>("Users");
            var one = collection.Find(x => x.Login == user.Login).FirstOrDefault();


            if (one == null)
            {

                collection.InsertOne(user);
            }
            else
            {
                return "Такой Логин уже существует";
            }
            return "";
            
        }
        public static User FindOne(string login)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("BlazorControlWork");
            var collection = database.GetCollection<User>("Users");
            var one = collection.Find(x => x.Login == login).FirstOrDefault();


            if (one == null)
            {
                return null;
                
            }
            else
            {
                return one;
            }
            

        }
    }
}
