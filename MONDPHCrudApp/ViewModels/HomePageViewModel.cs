using System;
using Xamarin.Forms;
using MONDPHCrudApp.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MONDPHCrudApp.ViewModels
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        private string _name;
        private string _email;
        private string _contact;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public string Contact
        {
            get { return _contact; }
            set
            {
                _contact = value;
                OnPropertyChanged();
            }
        }

        public Command RegisterCommand
        {
            get;
            set;
        }

        public HomePageViewModel()
        {
            Name = "Bryan";
            Email = "bryan@g.com";
            Contact = "2812574";

            RegisterCommand = new Command(() => Register());
        }

        public void Register()
        {
            Person person = new Person()
            {
                Name = Name,
                Email = Email,
                Contact = Contact
            };

            Name = "Bryan";
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
