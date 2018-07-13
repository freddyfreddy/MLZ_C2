using _20_MvvmFramework;
using Soccer_Manager.Model;
using Soccer_Manager.DataAccess;
using System.Collections.ObjectModel;
using System;
using System.Windows;

namespace Soccer_Manager.ViewModel
{
    public class ManagerViewModel : ObservableCollection
    {
        private readonly ObservableCollection<Position> _positionlist;
        private readonly ObservableCollection<Team> _teamlist;
        private  ObservableCollection<Player> _playerslist;

        public ManagerViewModel()
        {

            _positionlist = DBAdapter.GetAllPositions();
            _teamlist = DBAdapter.GetAllTeams();
            _playerslist = DBAdapter.GetPlayersFromNation(1);

        }

        public ObservableCollection<Player> Playerlist
        {
            get;
            set;
        }


        public void Event_Select_Swiss(object sender, RoutedEventArgs e)
        {
            //load Team Schweiz
            Console.WriteLine("Schweiz ist angewählt");

            DBAdapter.GetPlayersFromNation(1);
            //StatusColor = "Red";


        }
        private void Event_Select_France(object sender, RoutedEventArgs e)
        {
            //load Team Frankreich
            Console.WriteLine("Frankreich ist angewählt");

            DBAdapter.GetPlayersFromNation(2);
            //StatusColor = "Blue";
        }
        private void Event_Select_England(object sender, RoutedEventArgs e)
        {
            //load Team England
            Console.WriteLine("England ist angewählt");

            DBAdapter.GetPlayersFromNation(3);
            //StatusColor = "Orange";
        }





    }
}
