using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CornerButtonUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<Item> MyItems { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            MyItems = new ObservableCollection<Item>();
            MyItems.Add(new Item { MyItem = "Hello world0" });
            MyItems.Add(new Item { MyItem = "Hello world1" });
            MyItems.Add(new Item { MyItem = "Hello world2" });
            MyItems.Add(new Item { MyItem = "Hello world3" });
            MyItems.Add(new Item { MyItem = "Hello world4" });
            listView.DataContext = MyItems;
        }
    }

    public class Item
    {
        public string MyItem { get; set; }
    }
}
