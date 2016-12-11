using System.Windows;
using Logics;

namespace UI
{
    /// <summary>
    /// Логика взаимодействия для UISearch.xaml
    /// </summary>
    public partial class UISearch : Window
    {
       


        public UISearch()
        {
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UIMain UIMain = new UIMain();
            UIMain.listBoxMain.Items.Add(listBoxTvShows.SelectedItem);
        }
    }
}
