using System.Windows.Input;
using Zadatak_1.Commands;
using Zadatak_1.Validations;
using Zadatak_1.Views;

namespace Zadatak_1.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        MainWindow main;
        Validation validation = new Validation();

        private string username;

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                OnPropertyChanged("Username");
            }
        }

        private string password;

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        private ICommand logIn;

        public ICommand LogIn
        {
            get
            {
                if (logIn == null)
                {
                    logIn = new RelayCommand(param => LogInExecute(), param => CanLogInExecute());
                }
                return logIn;
            }
        }
        public MainWindowViewModel(MainWindow main)
        {
            this.main = main;
        }
        /// <summary>
        /// This method checks if username and password valid.
        /// </summary>
        public void LogInExecute()
        {
            if (Username == "Zaposleni" && Password == "Zaposleni")
            {
                
            }
            else if (validation.ValidationForJMBG(Username) == true && Password == "Gost")
            {
                GuestView guestView = new GuestView(Username);
                guestView.ShowDialog();
            }            
        }

        public bool CanLogInExecute()
        {
            return true;           
        }
    }
}

