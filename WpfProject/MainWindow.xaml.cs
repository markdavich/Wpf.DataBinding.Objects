using System.Windows;
using System.Windows.Media;
using WpfProject.Models;

namespace WpfProject;

public partial class MainWindow : Window
{
    public IEnumerable<ColorInfo> Colors => typeof(Brushes)
        .GetProperties()
        .Where(info => info.PropertyType == typeof(SolidColorBrush))
        .Select(info => 
            new ColorInfo()
            {
                Name = info.Name,
                Value = (SolidColorBrush)info.GetValue(info, null)!
            }
        ).ToList()! ?? Enumerable.Empty<ColorInfo>();

    public MainWindow()
    {
        InitializeComponent();
    }
}