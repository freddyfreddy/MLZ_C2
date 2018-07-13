using _20_MvvmFramework;
using Soccer_Manager.DataAccess;
using Soccer_Manager.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer_Manager.ViewModel
{
    public class TeamViewModel : ObservableCollection
    {

        private ObservableCollection<Team> _teams = new ObservableCollection<Team>();
        // private team variable
        private Team _team;

        public TeamViewModel()
        {
            _team = new Team();
        }
        // prop team
        public ObservableCollection<Team> Teams
        {
            get => _teams;
            set => _teams = value;
        }
        //add team to team collection
       
        
            



            // id property
            public int Id
            {
                get => _team.ID;
                set
                {
                    _team.ID = value;
                    RaisePropertyChanged();
                }
            }

            // title property
            public string Title
            {
                get => _team.Title;
                set
                {
                    _team.Title = value;
                    RaisePropertyChanged();
                }
            }


        
    }
}