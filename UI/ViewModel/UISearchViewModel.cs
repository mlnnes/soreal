using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logics.Data;
using Logics;
using System.Collections.ObjectModel;
using System.Windows;

namespace UI.ViewModel
{
    public class UISearchViewModel : ViewModelBase
    {
        Repository repository = new Repository();
        public UISearchViewModel()
        {

            SearchCommand = new RelayCommand(Search);
            //listTvShows.Clear();
            listTvShows = new ObservableCollection<TvShows>();
            for (int i = 0; i < repository.ListOfTvShows().Count; i++)
            {
                listTvShows.Add(repository.ListOfTvShows()[i]);
            }

        }
        private string query;

        public string Query
        {
            get
            {
                return query;
            }

            set
            {
                Set(() => Query, ref query, value);
            }
        }


        private ObservableCollection<TvShows> listTvShows;

        public ObservableCollection<TvShows> ListTvShows
        {
            get
            {
                return listTvShows;
            }

            set
            {
                Set(() => listTvShows, ref listTvShows, value);
            }
        }

        public RelayCommand SearchCommand { get; set; }





        private void Search()
        {
            try
            {
                listTvShows.Clear();
                foreach (var item in repository.SearchByName(query))
                {
                    listTvShows.Add(item);
                }
            }





            catch (ArgumentNullException)
            {

                MessageBox.Show("Enter the name of Tv Show", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                //textBoxSearch.Clear();
            }

            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Nothing was found:(", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                //textBoxSearch.Clear();
            }

            catch(FormatException)
            {
                MessageBox.Show("Enter the correct name of Tv Show", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }

    }

    }

