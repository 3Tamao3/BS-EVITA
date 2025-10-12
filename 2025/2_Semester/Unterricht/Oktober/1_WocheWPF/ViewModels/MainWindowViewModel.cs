    using CommunityToolkit.Mvvm.ComponentModel;
    using CommunityToolkit.Mvvm.Input;
    using System.Collections.Generic;

﻿namespace _1_WocheWPF.ViewModels;

    public partial class MainWindowViewModel : ObservableObject
    {
        private readonly Dictionary<string, string> _telefonbuch = new()
        {
            ["Max"]  = "+43 664 1234567",
            ["Lisa"] = "+43 664 9876543",
            ["Eva"]  = "+43 664 3214567",
        };

        [ObservableProperty]
        private string? nameInput;

        [ObservableProperty]
        private string? phoneNumber;

        [RelayCommand]
        private void Search()
        {
            if (string.IsNullOrWhiteSpace(NameInput))
            {
                PhoneNumber = "Namen eingeben:";
                return;
            }

            if (_telefonbuch.TryGetValue(NameInput.Trim(), out var nummer))
                PhoneNumber = $"{NameInput}: {nummer}";
            else
                PhoneNumber = $"'{NameInput}' nicht gefunden.";
        }
    }

}
