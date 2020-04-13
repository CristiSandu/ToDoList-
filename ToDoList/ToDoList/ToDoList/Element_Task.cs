using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace ToDoList
{
    public class Element_Task : BindableObject, INotifyPropertyChanged
    {
        public string Name
        {
            get { return _name; }
            set
            {              // OnPropertyChanged should not be called if the property value
                           // does not change.
                if (_name == value)
                    return;
                _name = value;
                OnPropertyChanged();
            }
        }
      
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _name;
    }
}
