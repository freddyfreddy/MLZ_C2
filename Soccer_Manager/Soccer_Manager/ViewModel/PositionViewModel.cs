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
    public class PositionViewModel : ObservableCollection
    {

        private ObservableCollection<Position> _positions = new ObservableCollection<Position>();
       

        public PositionViewModel()
        {
            _position = new Position();
        }
        // prop nations
        public ObservableCollection<Position> Positions
        {
            get => _positions;
            set => _positions = value;
        }
        //add positions to positions collection
       
            // private position variable
            private Position _position;



            // id property
            public int ID
            {
                get => _position.ID;
                set
                {
                    _position.ID = value;
                    RaisePropertyChanged();
                }
            }

            // title property
            public string Title
            {
                get => _position.Title;
                set
                {
                    _position.Title = value;
                    RaisePropertyChanged();
                }
            }


        
    }
}