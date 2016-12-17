using Logics;
using Logics.Data;
using Logics.UserData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UI
{
    /// <summary>
    /// Логика взаимодействия для UIForApixaml.xaml
    /// </summary>
    public partial class UIForApixaml : Window
    {
        TvShowManager tvShowManager;
        public UIForApixaml(TvShowManager _tvShowManager)
        {
            InitializeComponent();
            tvShowManager = _tvShowManager;
        }


        Repository repository = new Repository();
        private void ButtonSearchApi_Click(object sender, RoutedEventArgs e)
        {
            if (repository.SearchByName(textBoxSearch.Text) != null)
            {
                listBoxTvShowsApi.ItemsSource = repository.SearchByName(textBoxSearch.Text);
            }
            else
            {
                listBoxTvShowsApi.Items.Add("Nothing was found");
            }
        }

        private void listBoxTvShowsApi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UIInfo UIInfo = new UIInfo((TvShows)listBoxTvShowsApi.SelectedItem, tvShowManager);
            UIInfo.Show();
        }
    }
}
