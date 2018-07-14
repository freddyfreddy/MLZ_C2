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
        private readonly ObservableCollection<Position> positionlist;
        private readonly ObservableCollection<Team> teamlist;
        private  ObservableCollection<Player> playerslist;

        public ManagerViewModel()
        {

            positionlist = DBAdapter.GetAllPositions();
            teamlist = DBAdapter.GetAllTeams();
            playerslist = DBAdapter.GetPlayersFromNation(1);

        }

        public ObservableCollection<Player> Playerlist
        {
            get;
            set;
        }






    }
}
