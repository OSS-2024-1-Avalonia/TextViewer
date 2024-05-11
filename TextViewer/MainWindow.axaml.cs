using System.IO;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace TextViewer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void OpenButton_OnClick(object? sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var file = await openFileDialog.ShowAsync(this);
            TextBox.Text = File.ReadAllText(file[0]);
        }

        private async void SaveButton_OnClick(object? sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            var file = await saveFileDialog.ShowAsync(this);
            File.WriteAllText(file, TextBox.Text);
        }
    }
}