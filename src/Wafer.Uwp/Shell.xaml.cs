using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Wafer.Uwp.Views;
namespace Wafer.Uwp;

public sealed partial class Shell : UserControl
{
    internal IReadOnlyCollection<ItemEntry> NavigationItems;
    public Shell()
    {
        this.InitializeComponent();
        NavigationItems = new[] {
        new ItemEntry(IndexItem,typeof(IndexViewPage),"index")
        };
    }

    private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
    {
        if (NavigationItems.FirstOrDefault(item => item.Item == args.InvokedItemContainer).PageType is Type typepage)
        {
            NavigationFrame.Navigate(typepage);
        }
    }
}
/// <summary>
/// Items entry class
/// </summary>
internal sealed class ItemEntry
{
    public ItemEntry(NavigationViewItem item, Type pageType, string name)
    {
        Item = item;
        PageType = pageType;
        Name = name;
    }

    public NavigationViewItem Item { get; set; }
    public Type PageType { get; set; }
    public String Name { get; set; }
}
