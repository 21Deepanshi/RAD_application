using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBinding
{
    public class Person: INotifyPropertyChanged
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set 
            { 
                
                if(name != value)
                {
                    name = value;
                    //tell UI to change 
                    OnPropertyChanged("Name");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (age != value)
                {
                    age = value;
                    //tell UI to change 
                    OnPropertyChanged("Age");
                }
                else
                {
                    age = value;
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
