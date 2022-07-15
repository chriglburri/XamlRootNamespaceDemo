using System.Windows.Controls;
using BarWorkaround = global::Bar;

namespace Foo.Bar
{
  /// <summary>
  /// Interaction logic for Parent.xaml
  /// </summary>
  public partial class Parent : UserControl
  {
    // Workaround 1: use global
    internal global::Bar.Child MyChild_Workaround1;

    // Workaround 2: work with namespace alias
    internal BarWorkaround.Child MyChild_Workaround2;

    public Parent()
    {
      InitializeComponent();
    }
  }
}
