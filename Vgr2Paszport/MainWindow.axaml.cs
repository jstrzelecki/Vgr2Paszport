using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace Vgr2Paszport;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Numer_OnLostFocus(object? sender, RoutedEventArgs e)
    {
        if (Numer.Text == "222")
        {
            using var stream = AssetLoader.Open(new Uri("avares://Vgr2Paszport/Assets/222-zdjecie.jpg"));
            Photo1.Source = new Bitmap(stream);

            using var stream2 = AssetLoader.Open(new Uri("avares://Vgr2Paszport/Assets/222-odciski.jpg"));
            Fingerprints.Source = new Bitmap(stream2);
        }
        else if (Numer.Text == "000")
        {
            using var stream = AssetLoader.Open(new Uri("avares://Vgr2Paszport/Assets/000-zdjecie.jpg"));
            Photo1.Source = new Bitmap(stream);

            using var stream2 = AssetLoader.Open(new Uri("avares://Vgr2Paszport/Assets/000-odciski.jpg"));
            Fingerprints.Source = new Bitmap(stream2); 
        }
        
        else if (Numer.Text == "111")
        {
            using var stream = AssetLoader.Open(new Uri("avares://Vgr2Paszport/Assets/111-zdjecie.jpg"));
            Photo1.Source = new Bitmap(stream);

            using var stream2 = AssetLoader.Open(new Uri("avares://Vgr2Paszport/Assets/111-odciski.jpg"));
            Fingerprints.Source = new Bitmap(stream2); 
        }
        
        else if (Numer.Text == "333")
        {
            using var stream = AssetLoader.Open(new Uri("avares://Vgr2Paszport/Assets/333-zdjecie.jpg"));
            Photo1.Source = new Bitmap(stream);

            using var stream2 = AssetLoader.Open(new Uri("avares://Vgr2Paszport/Assets/333-odciski.jpg"));
            Fingerprints.Source = new Bitmap(stream2); 
        }
        
        
        else
        {
            using var stream = AssetLoader.Open(new Uri("avares://Vgr2Paszport/Assets/brak-zdjecie.jpg"));
            Photo1.Source = new Bitmap(stream);

            using var stream2 = AssetLoader.Open(new Uri("avares://Vgr2Paszport/Assets/brak-odciski.jpg"));
            Fingerprints.Source = new Bitmap(stream2);
        }
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        var color = "";
        if (Niebieskie.IsChecked == true)
        {
            color = "niebieskie";
        }

        else if (Zielone.IsChecked == true)
        {
            color = "zielone";
        }
        
        else if (Piwne.IsChecked == true)
        {
            color = "piwne";
        }
        
        Console.WriteLine($"{Imie.Text}, {Nazwisko.Text}, Kolor oczu: {color}");
     
        var popUpWindow = new PopUpWindow();
        popUpWindow.Info.Text = $"{Imie.Text}, {Nazwisko.Text}, Kolor oczu: {color}";
        popUpWindow.Show();
    }
}