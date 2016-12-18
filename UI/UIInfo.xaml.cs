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


        TvShowManager tvShowManager;

        public UIInfo(TvShows tvShow, TvShowManager _tvShowManager)
        {
            InitializeComponent();
            tvShowManager = _tvShowManager;
            labelName.Text = tvShow.Name;
            labelSeasons.Content = tvShow.TotalNumberOfSeasons;
            labelEpisodes.Content = tvShow.TotalNumberOfEpisodes;
            labelCountry.Content = tvShow.Country;
            textBoxCast.Text = tvShow.Cast;
        }


        

        private void buttonAddLater_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var tvShow = new NowTvShows(new TvShows
                {
                    Name = (string) labelName.Text,
                    TotalNumberOfSeasons = (int) labelSeasons.Content,
                    TotalNumberOfEpisodes = (int) labelEpisodes.Content,
                    Country = (string) labelCountry.Content,
                    Cast = (string) textBoxCast.Text

                });


                tvShowManager.AddLaterTvShow(tvShow);

                this.Close();
            }

            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }

        }



        public event Action<NowTvShows> OnAddNewToList;

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NowTvShows nowTvShow = new NowTvShows
                (
                    new TvShows
                    {
                        Name = (string)labelName.Text,
                        TotalNumberOfSeasons = (int)labelSeasons.Content,
                        TotalNumberOfEpisodes = (int)labelEpisodes.Content,
                        Country = (string)labelCountry.Content,
                        Cast = (string)labelCountry.Content

                    }

                );
                tvShowManager.AddNowTvShow(nowTvShow);

                this.Close();

                OnAddNewToList?.Invoke(nowTvShow);
            }

            catch (ArgumentException)
            {
                MessageBox.Show("This TV Show has already been added", "Error!", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        

        }

       
    }
}
