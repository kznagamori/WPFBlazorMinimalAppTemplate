using System;
using System.Windows;

namespace ___PROJECTNAME___
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // 起動時の処理をここに記述
            AppDomain.CurrentDomain.UnhandledException += (sender, error) =>
            {
                MessageBox.Show(error.ExceptionObject.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            };
        }
        protected override void OnExit(System.Windows.ExitEventArgs e)
        {
            // 終了時の処理をここに記述
            base.OnExit(e);
        }
    }
}

