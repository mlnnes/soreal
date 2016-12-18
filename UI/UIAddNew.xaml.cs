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
    /// Логика взаимодействия для UIAddNew.xaml
    /// </summary>
    public partial class UIAddNew : Window
    {

        TvShowManager tvShowManager;

        Repository repository = new Repository();

        public UIAddNew(TvShowManager _tvShowManager)
        {

            InitializeComponent();
            tvShowManager = _tvShowManager;

        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                repository.AddTvShowToDataBase(textBoxName.Text, textBoxCountry.Text, textBoxCast.Text,
                int.Parse(textBoxSeasons.Text), int.Parse(textBoxEpisodes.Text));


                tvShowManager.AddNowTvShow(new NowTvShows
               (
                      new TvShows
                      {


                          Name = textBoxName.Text,
                          TotalNumberOfSeasons = int.Parse(textBoxSeasons.Text),
                          TotalNumberOfEpisodes = int.Parse(textBoxEpisodes.Text),
                          Country = textBoxCountry.Text,
                          Cast = textBoxCast.Text

                      }


               ));
                this.Close();
            }
            catch (ArgumentNullException)
            {

                MessageBox.Show("Error", "Put information intu all textboxes", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Error", "Put information correctly", MessageBoxButton.OK, MessageBoxImage.Error);
            } 
            
            catch (Exception)// такой сериал уже есть эксепшн
            {

            }

            

        }

        private void buttonAddLater_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                repository.AddTvShowToDataBase(textBoxName.Text, textBoxCountry.Text, textBoxCast.Text,
               int.Parse(textBoxSeasons.Text), int.Parse(textBoxEpisodes.Text));

                var tvShow = new TvShows
                {
                    Name = textBoxName.Text,
                    TotalNumberOfSeasons = int.Parse(textBoxSeasons.Text),
                    TotalNumberOfEpisodes = int.Parse(textBoxEpisodes.Text),
                    Country = textBoxCountry.Text,
                    Cast = textBoxCast.Text

                };


                tvShowManager.AddLaterTvShow(tvShow);

                this.Close();
            }
            catch (ArgumentNullException)
            {

                MessageBox.Show("Error", "Put information intu all textboxes", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Error", "Put information correctly", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            catch (Exception)// такой сериал уже есть эксепшн
            {

            }

        }
    }
}
