using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using System.Linq;
using Avalonia.Markup.Xaml;
using _1_WocheWPF.ViewModels;
using _1_WocheWPF.Views;

namespace _1_WocheWPF;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {

        // Additional initialization code here
        Dictionary<string, string> telefonbuch = new Dictionary<string, string>();
        telefonbuch.Add("Max", "+43 664 1234567");
        telefonbuch.Add("Lisa", "+43 664 9876543");
        telefonbuch.Add("Eva", "+43 664 3214567");

        foreach (var entry in telefonbuch)
        {
            Debug.WriteLine($"{entry.Key}: {entry.Value}");
        }
        Console.WriteLine("Input: ");
        string userInput = Console.ReadLine();

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // Avoid duplicate validations from both Avalonia and the CommunityToolkit.
            // More info: https://docs.avaloniaui.net/docs/guides/development-guides/data-validation#manage-validationplugins
            DisableAvaloniaDataAnnotationValidation();
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }

    private void DisableAvaloniaDataAnnotationValidation()
    {
        // Get an array of plugins to remove
        var dataValidationPluginsToRemove =
            BindingPlugins.DataValidators.OfType<DataAnnotationsValidationPlugin>().ToArray();

        // remove each entry found
        foreach (var plugin in dataValidationPluginsToRemove)
        {
            BindingPlugins.DataValidators.Remove(plugin);
        }
    }
}
