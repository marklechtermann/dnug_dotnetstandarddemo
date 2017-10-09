using MyBusinessLayer;
using MyBusinessLayer.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace UWPDemo.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private Starship starship;
        private SwapiAccess swapiAccess = new SwapiAccess();

        public MainPageViewModel()
        {
            this.GoCommand = new RelayCommand(() => { this.Starship = swapiAccess.GetRandomStarship(); });
        }

        public Starship Starship
        {
            get
            {
                return this.starship;
            }
            set
            {
                this.starship = value;
                this.OnPropertyChanged("Starship");
            }
        }

        public ICommand GoCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}