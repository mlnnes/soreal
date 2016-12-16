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
using Logics.Data;
namespace UI
{
    /// <summary>
    /// Логика взаимодействия для UIInfo.xaml
    /// </summary>
    public partial class UIInfo : Window
    {
        TvShowManager tvShowManager = new TvShowManager();
        public UIInfo(TvShows tvShow)
        {
            InitializeComponent();

            labelName.Content = tvShow.Name;
            labelSeasons.Content = tvShow.TotalNumberOfSeasons;
            labelEpisodes.Content = tvShow.TotalNumberOfEpisodes;
            labelCountry.Content = tvShow.Country;
            textBoxCast.Text = tvShow.Cast;
        }

        private void buttonAddLater_Click(object sender, RoutedEventArgs e)
        {


            tvShowManager.AddLaterTvShow(new TvShows
            {
                Name = (string)labelName.Content,
                TotalNumberOfSeasons = (int)labelSeasons.Content,
                TotalNumberOfEpisodes = (int)labelEpisodes.Content,
                Country = (string)labelCountry.Content,
                Cast = (string)labelCountry.Content

            });

        }



        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            tvShowManager.AddNowTvShow(new NowTvShows
            (
                   new TvShows
                   {
                       Name = (string)labelName.Content,
                       TotalNumberOfSeasons = (int)labelSeasons.Content,
                       TotalNumberOfEpisodes = (int)labelEpisodes.Content,
                       Country = (string)labelCountry.Content,
                       Cast = (string)labelCountry.Content

                   }

            ));
        }
    }
}
