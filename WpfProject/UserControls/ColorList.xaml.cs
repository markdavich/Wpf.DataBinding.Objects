using System.Windows;
using System.Windows.Controls;
using WpfProject.Models;

namespace WpfProject.UserControls;

public partial class ColorList : UserControl
{
    // ✶ Binding Dependency Property
    public static readonly DependencyProperty ColorsProperty =
        DependencyProperty.Register(
            name: nameof(Colors),                             // The "Name" of the property to register
            propertyType: typeof(IEnumerable<ColorInfo>),     // The "Type" of the property to register
            ownerType: typeof(ColorList),          // The "Type" of object that owns the property to register
            typeMetadata: new FrameworkPropertyMetadata(
                defaultValue: Enumerable.Empty<ColorInfo>(),
                flags: FrameworkPropertyMetadataOptions.None
            )
        );

    // ✶ Binding Property
    public IEnumerable<ColorInfo> Colors
    {
        get => (IEnumerable<ColorInfo>)GetValue(ColorsProperty); // ✶ Binding Getter 
        set => SetValue(ColorsProperty, value); // ✶ Binding Setter
    }

    public ColorList()
    {
        InitializeComponent();
    }
}
