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
    /// Логика взаимодействия для UIControlling.xaml
    /// </summary>
    public partial class UIControlling : Window
    {
        TvShowManager tvShowManager = new TvShowManager();
        //вот это плохо вроде
        NowTvShows nowTvShow;
        public UIControlling(NowTvShows _nowTvShow)
        {
            InitializeComponent();
            labelName.Content = _nowTvShow.Name;
            labelNowEpisode.Content = string.Format(" Seson {0}  episode {1}", _nowTvShow.NowSeason, _nowTvShow.NowEpisode);
            nowTvShow = _nowTvShow;
        }

        private void ButtonAddEpisode_Click(object sender, RoutedEventArgs e)
        {
            // вроде не сработет
            tvShowManager.AddSeenEpisode(nowTvShow);
            labelNowEpisode.Content = string.Format(" Seson {0}  episode {1}", nowTvShow.NowSeason, nowTvShow.NowEpisode);

        }
    }
}
