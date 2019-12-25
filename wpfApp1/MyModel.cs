using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApp1
{
    class MyModel : INotifyPropertyChanged
    {
        public string Data
        {
            get => _Data;
            set
            {
                if (value == Data)
                    return;
                _Data = value;
                OnPropertyChanged(nameof(Data));
            }
        }
        private string _Data = "My Data!";

        public void ClearData()
        {
            Data = "";
        }
        private void OnPropertyChanged(string aPropertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(aPropertyName));
        public event PropertyChangedEventHandler PropertyChanged;
    }
}