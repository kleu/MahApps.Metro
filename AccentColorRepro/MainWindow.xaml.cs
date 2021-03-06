﻿using System.Linq;
using System.Windows;
using MahApps.Metro;
using MahApps.Metro.Controls;

namespace AccentColorRepro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private string lastUsedAccent;

        public MainWindow()
        {
            InitializeComponent();
            lastUsedAccent = "Blue";
            ThemeManager.ChangeTheme(this, ThemeManager.DefaultAccents.First(x => x.Name == lastUsedAccent), Theme.Light);
        }

        private void DarkButtonClick(object sender, RoutedEventArgs e)
        {
            ThemeManager.ChangeTheme(this, ThemeManager.DefaultAccents.First(x => x.Name == lastUsedAccent), Theme.Dark);
        }

        private void LightButtonClick(object sender, RoutedEventArgs e)
        {
            ThemeManager.ChangeTheme(this, ThemeManager.DefaultAccents.First(x => x.Name == lastUsedAccent), Theme.Light);
        }

        private void BlueButtonClick(object sender, RoutedEventArgs e)
        {
            lastUsedAccent = "Blue";
            ThemeManager.ChangeTheme(this, ThemeManager.DefaultAccents.First(x => x.Name == lastUsedAccent), ThemeManager.ThemeIsDark ? Theme.Dark : Theme.Light);
        }

        private void RedButtonClick(object sender, RoutedEventArgs e)
        {
            lastUsedAccent = "Red";
            ThemeManager.ChangeTheme(this, ThemeManager.DefaultAccents.First(x => x.Name == lastUsedAccent), ThemeManager.ThemeIsDark ? Theme.Dark : Theme.Light);
        }

        private void GreenButtonClick(object sender, RoutedEventArgs e)
        {
            lastUsedAccent = "Green";
            ThemeManager.ChangeTheme(this, ThemeManager.DefaultAccents.First(x => x.Name == lastUsedAccent), ThemeManager.ThemeIsDark ? Theme.Dark : Theme.Light);
        }
    }
}
