﻿
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace JumpKing_GamepadVibration.Model
{
    public class Preferences: INotifyPropertyChanged
    {
        private bool _isEnabled = false;
        
        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                _isEnabled = value;
                OnPropertyChanged(nameof(IsEnabled));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}