using System.Windows;
using System.Windows.Controls;
using Scapeulator.ViewModels;

namespace Scapeulator;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();

        if (listShapes != null)
        {
            listShapes.SelectedIndex = 0;
        }
    }

    private void ListShapes_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        ListBox lb = (ListBox)sender;
        if (lb.SelectedItem is string lbi)
        {
            MessageBox.Show(lbi);
        }
    }
}