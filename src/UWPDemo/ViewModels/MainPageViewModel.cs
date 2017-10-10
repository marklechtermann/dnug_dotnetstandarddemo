using MyBusinessLayer;
using MyBusinessLayer.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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
                this.OnPropertyChanged();
            }
        }

        public ICommand GoCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = "")
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}