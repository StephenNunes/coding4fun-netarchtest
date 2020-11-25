using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using MyAwesomeApplication.PresentationLayer.Models;
using MyAwesomeApplication.DataAccessLayer;

namespace MyAwesomeApplication.PresentationLayer.ViewModels
{
    public class CakeViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Cake> _displayedCakes;

        public ObservableCollection<Cake> DisplayedCakes 
        { 
            get { return _displayedCakes; }
            set
            {
                _displayedCakes = value;
                NotifyPropertyChanged(nameof(DisplayedCakes));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName)  
        {  
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Test()
        {
            var repository = new CakeRepository();
        }
    }
}
