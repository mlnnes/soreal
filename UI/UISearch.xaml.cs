﻿using System.Windows;
using Logics;
using Logics.Data;

namespace UI
{
    /// <summary>
    /// Логика взаимодействия для UISearch.xaml
    /// </summary>
    public partial class UISearch : Window
    {



        public UISearch()
        {

            InitializeComponent();
            listBoxTvShows.ItemsSource = Repository.ListOfTvShows();

        }

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {

            listBoxTvShows.Items.Clear();

            try
            {
                listBoxTvShows.ItemsSource = Repository.SearchByName(textBoxSearch.Text);
            }
            catch (System.Exception)
            {

                listBoxTvShows.Items.Add("Nothing was found");
            }


            //if (Repository.SearchByName() != null)
            //{
            //    ButtonSearchInternet.Visibility = Visibility.Hidden;
            //    ButtonAddNew.Visibility = Visibility.Hidden;

            //    for (int i = 0; i < Repository.SearchByName(textBoxSearch.Text).Count; i++)
            //    {
            //        listBoxTvShows.Items.Add(Repository.SearchByName(textBoxSearch.Text)[i]);
            //    }


            //}
            //else
            //{
            //    ButtonSearchInternet.Visibility = Visibility.Visible;
            //    ButtonAddNew.Visibility = Visibility.Visible;

            //}

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UIMain UIMain = new UIMain();
            UIMain.listBoxMain.Items.Add(listBoxTvShows.SelectedItem);
        }

        private void listBoxTvShows_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            //не уверен что сработает
            UIInfo UIInfo = new UIInfo((TvShows)listBoxTvShows.SelectedItem);
            //listBoxTvShows.SelectedItem

        }

        private void ButtonAddNew_Click(object sender, RoutedEventArgs e)
        {
            UIAddNew UiAddNew = new UIAddNew();

        }

        private void ButtonSearchInternet_Click(object sender, RoutedEventArgs e)
        {

            //надо сделать апи
        }




    }
}