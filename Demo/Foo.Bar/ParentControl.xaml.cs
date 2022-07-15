using System.Windows.Controls;
using BarWorkaround = Bar;

namespace Foo.Bar
{
  public partial class PartentControl : UserControl
  {
    // Workaround 1: use global
    internal global::Bar.ChildControl MyChild_Workaround1;

    // Workaround 2: work with namespace alias
    internal BarWorkaround.ChildControl MyChild_Workaround2;

    public PartentControl()
    {
      InitializeComponent();
    }
  }
}