using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soccer_Manager.Model;
using System.Collections.ObjectModel;

namespace Soccer_Manager.DataAccess
{
    public static class DBAdapter
    {

        public static ObservableCollection<Team> GetAllTeams()
        {
            using (SoccerEntities context = new SoccerEntities())
            {
                List<Team> teams = context.Teams.ToList();
                var ocTeam = new ObservableCollection<Team>();

                foreach (Team team in DBAdapter.GetAllTeams())
                {
                    ocTeam.Add(new Team()
                    {
                        ID = (team.ID),
                        Title = team.Title
                    });
                }
                return ocTeam;
            }


        }

        public static ObservableCollection<Position> GetAllPositions()
        {
            using (SoccerEntities context = new SoccerEntities())
            {
                List<Position> positions = context.Positions.ToList();
                var ocPosition = new ObservableCollection<Position>();


                foreach (Position position in DBAdapter.GetAllPositions())
                {
                    ocPosition.Add(new Position()
                    {
                        ID = (position.ID),
                        Title = position.Title
                    });
                }


                return ocPosition;
            }

        }

        public static ObservableCollection<Player> GetPlayersFromNation(int nation)
        {
            using (SoccerEntities context = new SoccerEntities())

            {
                List<Player> players = (from p in context.Players where p.TeamID == nation select p).ToList<Player>();
                var ocPlayers = new ObservableCollection<Player>();


                foreach (Player player in DBAdapter.GetPlayersFromNation(nation))
                {
                    ocPlayers.Add(new Player()
                    {
                        Lastname = player.Lastname,
                        Firstname = player.Firstname,
                        Height = player.Height,
                        Jerseynumber = player.Jerseynumber,
                        Birthdate = player.Birthdate,
                        PositionID = player.PositionID,
                        Playedgames = player.Playedgames,
                        Goals = player.Goals,
                        TeamID = player.TeamID
                    });
                }



                return ocPlayers;
            }
        }
    }
}



    

