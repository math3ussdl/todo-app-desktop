using TodoApp.Intefaces;

namespace TodoApp.Classes
{
    public class User : IUserInterfaceLogin
    {
        public readonly IUserInterfaceLogin userData;

        public User(IUserInterfaceLogin userData)
        {
            this.userData = userData;
        }

        public string Id {
            get;
            set;
        }

        public string Name {
            get;
            set;
        }

        public string Phone {
            get;
            set;
        }

        public string Email {
            get;
            set;
        }

        public string Password {
            get;
            set;
        }

    }
}
