using ASM.Model;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ASM
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<MenuItem> MenuItems;

        public ObservableCollection<New> News { get; private set; }

        public MainPage()
        {
            this.InitializeComponent();
            News = new ObservableCollection<New>();
            NewManager.GetAllNews(News);
            MenuItems = new List<MenuItem>();
            MenuItems.Add(new MenuItem { Icon = "Assets/Icons/gaming.jpg", Category = NewCategory.Gaming });
            MenuItems.Add(new MenuItem { Icon = "Assets/Icons/football.jpg", Category = NewCategory.Entertainment });
            MenuItems.Add(new MenuItem { Icon = "Assets/Icons/product.jpg", Category = NewCategory.Productivity });
            MenuItems.Add(new MenuItem { Icon = "Assets/Icons/deal.jpg", Category = NewCategory.Deal });
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NewManager.GetAllNews(News);
            CategoryTextBlock.Text = "All News";
            MenuItemsListView.SelectedItem = null;
            BackButton.Visibility = Visibility.Collapsed;
        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void MenuItemsListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var menuItem = (MenuItem)e.ClickedItem;
            CategoryTextBlock.Text = menuItem.Category.ToString();
            NewManager.GetByCategory(News, menuItem.Category);
            BackButton.Visibility = Visibility.Visible;

        }

        private void NewGridView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
