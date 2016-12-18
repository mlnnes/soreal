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
using Logics.UserData;
namespace UI
{
    /// <summary>
    /// Логика взаимодействия для UIMain.xaml
    /// </summary>
    public partial class UIMain : Window
    {

        TvShowManager tvShowManager = new TvShowManager();
        public UIMain()
        {
            InitializeComponent();
            //tvShowManager.OnAdding += tvshow => tvShowManager.LaterTvShowsList.Add(tvshow);
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            UISearch UISearch = new UISearch(tvShowManager);
            UISearch.Show();

        }





        private void ButtonSeen_Click(object sender, RoutedEventArgs e)
        {

            listBoxMain.ItemsSource = tvShowManager.AlreadyTvShowsList;
        }

        private void ButtonWillWatch_Click(object sender, RoutedEventArgs e)
        {

            listBoxMain.ItemsSource = tvShowManager.LaterTvShowsList;
        }

        private void ButtonWatching_Click(object sender, RoutedEventArgs e)
        {
            listBoxMain.ItemsSource = tvShowManager.NowTvShowsList;

        }

        private void listBoxMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBoxMain.SelectedItem is NowTvShows)
            {
                UIControlling UIControlling = new UIControlling((NowTvShows)listBoxMain.SelectedItem, tvShowManager);
                UIControlling.Show();

            }

        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            
            //вызов метода удаления из листа
            //кстати можно событие приделать здесь
        }
    }
}
