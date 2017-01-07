using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedProject
{
    public class Dao 
    {
        dbDialogoweEntities contex = new dbDialogoweEntities();

        public  bool checkConnection()
        {
            try
            {
                var x = new dbDialogoweEntities();

                x.Database.Connection.Open();
                x.Database.Connection.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public  List<FieldType> GetFieldTypes()
        {
            return contex.FieldType.ToList();
        }

        public List<UnitType> GetUnitTypes()
        {
            return contex.UnitType.ToList();
        }

        public List<Field> GetFields()
        {
            return contex.Field.ToList();
        }

        public Field GetField(int id)
        {
            return contex.Field.SingleOrDefault(s => s.IDField == id);
        }

        public User GetUser(int id)
        {
            return contex.User.SingleOrDefault(s => s.IDUser == id);
        }

        public Board GetBoard(int id)
        {
            return contex.Board.SingleOrDefault(s => s.IDBoard == id);
        }

        public Game GetGame(int id)
        {
            return contex.Game.SingleOrDefault(s => s.IDGame == id);
        }

        public List<Unit> GetUnits()
        {
            return contex.Unit.ToList();
        }
    }
}
