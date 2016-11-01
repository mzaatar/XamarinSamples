using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PhonewordPortalable
{
    public class PhoneNumbersViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Phone> _phoneNumbers = new ObservableCollection<Phone>();
        public ObservableCollection<Phone> PhoneNumbers
        {
            get { return _phoneNumbers; }
            set { _phoneNumbers = value; OnPropertyChanged("PhoneNumbers"); } //I have also tried with Title property
        }

        public void Clear()
        {
            _phoneNumbers.Clear();
            OnPropertyChanged("PhoneNumbers");
        }

        public void Add(string key, string value)
        {
            var obj = new Phone(key, value);
            if (_phoneNumbers.Contains(obj))
            {
                _phoneNumbers.Remove(obj);
            }
            _phoneNumbers.Add(obj);
            OnPropertyChanged("PhoneNumbers");
        }

        public int Count
        {
            get
            {
                return _phoneNumbers.Count;
            }
        }


        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
