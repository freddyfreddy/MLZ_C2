using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using _20_MvvmFramework;
using Soccer_Manager.Model;
using System.Threading;
using System.Collections.ObjectModel;
using Soccer_Manager.DataAccess;

namespace Soccer_Manager.ViewModel
{
    public class PlayerViewModel : ObservableCollection
    {

        private ObservableCollection<Player> _players = new ObservableCollection<Player>();
        // private team variable
        private Player _player;
        public PlayerViewModel()
        {
            _player = new Player();
        }
        // prop team
        public ObservableCollection<Player> Players
        {
            get => _players;
            set => _players = value;
        }
        //add team to team collection
        

       

     







        //Team team = (from t in ContextBoundObject.Team1.Include("Player")
        //             where t.TeamID == 1
        //             select t).FirstOrDefault();

        //return pList;

        //public string Color
        //{

        //    get
        //    {
                
        //        return _player.Color;
        //    }
        //    set
        //    {
        //        _player.Color = value;

        //        RaisePropertyChanged();
        //    }
        //}



        public string Lastname
        {

            get
            {
                
                return _player.Lastname;
            }
            set
            {
                _player.Lastname = value;
               
                RaisePropertyChanged();
            }
        }
        public string Firstname
        {
            get { return _player.Firstname; }
            set
            {
                _player.Firstname = value;
                RaisePropertyChanged();
            }
        }

        public int? Height
        {
            get { return _player.Height; }
            set
            {
                _player.Height = value;
                RaisePropertyChanged();
            }
        }

        public DateTime? Birthdate
        {
            get { return _player.Birthdate; }
            set
            {
                _player.Birthdate = value;
                RaisePropertyChanged();
            }
        }

        public int? Jerseynumber
        {
            get { return _player.Jerseynumber; }
            set
            {
                _player.Jerseynumber = value;
                RaisePropertyChanged();
            }
        }

        public int? PositionID
        {
            get { return _player.PositionID; }
            set
            {
                _player.PositionID = value;
                RaisePropertyChanged();
            }
        }

        public int? Playedgames
        {
            get { return _player.Playedgames; }
            set
            {
                _player.Playedgames = value;
                RaisePropertyChanged();
            }
        }

        public int? Goals
        {
            get { return _player.Goals; }
            set
            {
                _player.Goals = value;
                RaisePropertyChanged();
            }
        }

        public int? TeamID
        {
            get { return _player.TeamID; }
            set
            {
                _player.TeamID = value;
                RaisePropertyChanged();
            }
        }

        #region Commands

        void DeletePlayerCommandExecute()
        {
            using (SoccerEntities context = new SoccerEntities())
            {
                {
                    var pers = (from p in context.Players
                                where p.ID == _player.ID
                                select p).FirstOrDefault();


                    context.Players.Remove(_player);
                    context.SaveChanges();
                }
                Console.WriteLine("Delete Player");
            }
        }

        bool DeletePlayerCommandCanExecute()
        {
            return true;
        }

        void UpdatePlayerCommandExecute()
        {
            using (SoccerEntities context = new SoccerEntities())

            {
                var pers = (from p in context.Players
                            where p.ID == _player.ID
                            select p).FirstOrDefault();

                pers.Lastname = _player.Lastname;
                pers.Firstname = _player.Firstname;
                pers.Height = _player.Height;
                pers.Jerseynumber = _player.Jerseynumber;
                pers.Birthdate = _player.Birthdate;
                pers.PositionID = _player.PositionID;
                pers.Playedgames = _player.Playedgames;
                pers.Goals = _player.Goals;
                pers.TeamID = _player.TeamID;

            }
            Console.WriteLine("Update Player");
        }

        bool UpdatePlayerCommandCanExecute()
        {
            return true;
        }

        void NewPlayerCommandExecute()
        {
            using (SoccerEntities context = new SoccerEntities())
            {
                //player erstellen
                context.Players.Add(_player);
                context.SaveChanges();

            }
            Console.WriteLine("New Player");
        }

        bool NewPlayerCommandCanExecute()
        {
            return true;
        }

        public ICommand DeletePlayer
        {
            get
            {
                return new RelayCommand(
                    DeletePlayerCommandExecute,
                    DeletePlayerCommandCanExecute
                    );
            }
        }

        public ICommand UpdatePlayer
        {
            get
            {
                return new RelayCommand(
                    UpdatePlayerCommandExecute,
                    UpdatePlayerCommandCanExecute
                    );
            }
        }
        public ICommand NewPlayer
        {
            get
            {
                return new RelayCommand(
                    UpdatePlayerCommandExecute,
                    UpdatePlayerCommandCanExecute
                    );
            }
        }

        #endregion
    }
}



