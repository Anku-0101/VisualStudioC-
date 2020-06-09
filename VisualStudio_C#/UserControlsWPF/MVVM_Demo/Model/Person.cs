using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Demo.Model
{
    public class Person : INotifyPropertyChanged , IDataErrorInfo
    {
        private string fName;
        public string FName
        {
            get
            {
                return fName;
            }

            set
            {
                fName = value;
                //OnPropertyChanged(FName);
            }
        }

        private string lName;
        public string LName
        {
            get
            {
                return lName;
            }

            set
            {
                lName = value;
                //OnPropertyChanged(LName);
            }
        }

        private string fullName;
        public string FullName
        {
            get
            {
                return fullName = FName + " " + LName;
            }

            set
            {
                fullName = value;
            }
        }

        public DateTime DateAdded { get; set; }

        public string Error
        {
            get
            {
                return null;
            }
        }

        public string this[string PropertyName]
        {
            get
            {
                string result = String.Empty;

                switch (PropertyName)
                {
                    case "FName":
                        if (string.IsNullOrEmpty(FName)) ;
                        result = "First Name Required";
                        break;

                    case "LName":
                        if (string.IsNullOrEmpty(FName)) ;
                        result = "Last Name Required";
                        break;
                }

                return result;

                }
            }
       

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string p)
        {
            PropertyChangedEventHandler ph = PropertyChanged;

            if(ph != null)
            {
                ph(this, new PropertyChangedEventArgs(p));
            }
        }

    }
}

        


        