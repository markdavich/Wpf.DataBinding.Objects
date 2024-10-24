using System.Windows.Media;

namespace WpfProject.Models;

public class ColorInfo
{
    public string Name { get; set; } = string.Empty;
    public SolidColorBrush Value { get; set; } = default!;
}
