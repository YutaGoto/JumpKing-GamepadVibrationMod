using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace JumpKing_GamepadVibration.Model
{
    public class Preferences: INotifyPropertyChanged
    {
        private bool _isEnabled = false;
        private bool _isLanded = false;
        private bool _isKnocked = false;
        private bool _giantBootsPower = false;

        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                _isEnabled = value;
                OnPropertyChanged(nameof(IsEnabled));
            }
        }

        public bool IsLanded {
            get => _isLanded;
            set
            {
                _isLanded = value;
                OnPropertyChanged(nameof(IsLanded));
            }
        }

        public bool IsKnocked
        {
            get => _isKnocked;
            set
            {
                _isKnocked = value;
                OnPropertyChanged(nameof(IsKnocked));

            }
        }

        public bool GiantBootsPower
        {
            get => _giantBootsPower;
            set
            {
                _giantBootsPower = value;
                OnPropertyChanged(nameof(GiantBootsPower));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
