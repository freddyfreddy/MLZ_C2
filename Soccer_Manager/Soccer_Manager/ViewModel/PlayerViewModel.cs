using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using _20_MvvmFramework;
using Soccer_Manager.Model;

namespace Soccer_Manager.ViewModel
{
    public class PlayerViewModel : ObservableObject
    {

        public List<Player> GetPlayerFromNation(int nation)
        {
            using (SoccerEntities context = new SoccerEntities())
            {
                return null;
                //List<Player> pList = (from p in context.Players where p.TeamID == nation select p).ToList<Player>();
                //Team team = (from t in ContextBoundObject.Team1.Include("Player")
                //             where t.TeamID == 1
                //             select t).FirstOrDefault();
                //List<Player> players = (from p in ContextBoundObject.Players select p).ToList<Player>();
                //return pList;
            }
        }
    }

}
        //private Player _player;

        //public PlayerViewModel()
        //{
        //    _player = GetPlayer();
        //}

        //public string Firstname
        //{
        //    get { return _player.Firstname; }
        //    set
        //    {
        //        _player.Firstname = value;
        //        RaisePropertyChanged();
        //    }
        //}
        //public string Lastname
        //{
        //    get { return _player.Lastname; }
        //    set
        //    {
        //        _player.Lastname = value;
        //        RaisePropertyChanged();
        //    }
        //}
        //public string Height
        //{
        //    get { return _player.Height; }
        //    set
        //    {
        //        _player.Height = value;
        //        RaisePropertyChanged();
        //    }
        //}
        //public DateTime Birthdate
        //{
        //    get { return _player.Birthdate; }
        //    set
        //    {
        //        _player.Birthdate = value;
        //        RaisePropertyChanged();
        //    }
        //}
        //public int Jerseynumber
        //{
        //    get { return _player.Jerseynumber; }
        //    set
        //    {
        //        _player.Jerseynumber = value;
        //        RaisePropertyChanged();
        //    }
        //}
        //public int Position //achtung Position ID in einen Position wechseln
        //{
        //    get { return _player.Position; }
        //    set
        //    {
        //        _player.Position = value;
        //        RaisePropertyChanged();
        //    }
        //}
        //public int Playedgames
        //{
        //    get { return _player.Playedgames; }
        //    set
        //    {
        //        _player.Playedgames = value;
        //        RaisePropertyChanged();
        //    }
        //}
        //public int Goals
        //{
        //    get { return _player.Goals; }
        //    set
        //    {
        //        _player.Goals = value;
        //        RaisePropertyChanged();
        //    }
        //}
        //public image Picture
        //{
        //    get { return _player.Jerseynumber; }
        //    set
        //    {
        //        _player.Jerseynumber = value;
        //        RaisePropertyChanged();
        //    }
        //}
        //public int TeamID    //achtung ID in name wechseln
        //{
        //    get { return _player.TeamID; }
        //    set
        //    {
        //        _player.TeamID = value;
        //        RaisePropertyChanged();
        //    }
        //}




        //#region Commands


        //void UpdateAuthorCommandExecute()
        //{
        //    Author = Author + "T";
        //}

        //bool UpdateAuthorCommandCanExecute()
        //{
        //    return true;
        //}


        //public ICommand UpdateAuthor
        //{
        //    get
        //    {
        //        return new RelayCommand(
        //            UpdateAuthorCommandExecute,
        //            UpdateAuthorCommandCanExecute
        //            );
        //    }



        //}
        //#endregion









   

   