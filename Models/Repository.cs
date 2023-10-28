namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1, Name = "John Doe", Email = "johndoe@example.com", Phone = "+1 (555) 123-4567", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2, Name = "Emily Johnson", Email = "emily.j@example.com", Phone = "+1 (555) 987-6543", WillAttend = true });
            _users.Add(new UserInfo() { Id = 3, Name = "Michael Anderson", Email = "michael.anderson@example.com", Phone = "+1 (555) 456-7890", WillAttend = false });
        }

        public static List<UserInfo> Users { 
            get {  
                return _users; 
            } 
        }

        public static void CreateUser(UserInfo user) {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}