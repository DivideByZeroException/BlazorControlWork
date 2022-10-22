namespace BlazorControlWork
{
    public static class Session
    {
        private static string login = "";
        private static string name = "";
        private static string second_name = "";
        private static string email = "";

        public static string Login { get => login; set => login = value; }
        public static string Name { get => name; set => name = value; }
        public static string Second_name { get => second_name; set => second_name = value; }
        public static string Email { get => email; set => email = value; }
    }
}
