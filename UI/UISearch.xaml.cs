using System.Windows;
using Logics;
using Logics.Data;
using Logics.UserData;
using System;

namespace UI
{
    /// <summary>
    /// Логика взаимодействия для UISearch.xaml
    /// </summary>
    public partial class UISearch : Window
    {

        TvShowManager tvShowManager;
        Repository repository = new Repository();

        public UISearch(TvShowManager _tvShowManager)
        {
            tvShowManager = _tvShowManager;
            InitializeComponent();
          
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UIMain UIMain = new UIMain();
            UIMain.listBoxMain.Items.Add(listBoxTvShows.SelectedItem);
        }

        private void listBoxTvShows_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            
            UIInfo UIInfo = new UIInfo((TvShows)listBoxTvShows.SelectedItem, tvShowManager);
            UIInfo.Show();
            //listBoxTvShows.SelectedItem

        }

        private void ButtonAddNew_Click(object sender, RoutedEventArgs e)
        {
            UIAddNew UIAddNew = new UIAddNew(tvShowManager);
            UIAddNew.Show();

        }

        private void ButtonSearchInternet_Click(object sender, RoutedEventArgs e)
        {
            UIForApixaml UIApiSearch = new UIForApixaml(tvShowManager);
            UIApiSearch.Show();
            this.Close();
        }

        
    }
}
