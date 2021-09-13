using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaUI
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Contact> Contacts { get; set; } = new();

        public string FirstName { get; set; } = "FirstName Test";
        public string LastName { get; set; } = "LastName Test";

        public event PropertyChangedEventHandler PropertyChanged;

        public void AddContact()
        {
            var contact = new Contact
            {
                FirstName = FirstName,
                LastName = LastName
            };
            Contacts.Add(contact);

            FirstName = "";
            LastName = "";

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastName)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FirstName)));
        }
    }
}
