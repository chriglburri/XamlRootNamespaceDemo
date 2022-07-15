# XamlRootNamespaceDemo
A demo application to show the problem of the root namespaces in XAML compiler

## Situaion
There are 2 user controls in 2 different namespaces:

* Bar.Child
* Foo.Bar.Parent

The control Parent.xaml is using the control Child.xaml, and defines its x:Name as "MyChild"

This will generate a file Parent.g.i.cs which declares the following instance variable:
```
	internal Bar.Child MyChild;
```

It can not be compiled with the message:
  The type or namespace name 'Child' does not exist in the namespace 'Foo.Bar' (are you missing an assembly reference?)

## Possible workarounds

As described in the file Parent.xaml.cs there are 2 proper solutions for the problem:

* The XAML compiler generates a global:: alias when generating the variable declaration.
* The Xaml compiler generates an alias in the using section which can be used in the declaration:

```
using BarWorkaround = global::Bar;

namespace Foo.Bar
{
  public partial class Parent : UserControl
  {
    // Workaround 1: use global
    internal global::Bar.Child MyChild_Workaround1;

    // Workaround 2: work with namespace alias
    internal BarWorkaround.Child MyChild_Workaround2;

    //...
  }
}

```