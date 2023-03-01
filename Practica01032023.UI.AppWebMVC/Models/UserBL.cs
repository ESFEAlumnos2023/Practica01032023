namespace Practica01032023.UI.AppWebMVC.Models
{
    public class UserBL
    {
        static List<User> users = new List<User>();
        public List<User> ObtenerTodos()
        {
            return users;
        }
        public int Crear(User user)
        {
            users.Add(user);
            return 1;
        }
    }
}
